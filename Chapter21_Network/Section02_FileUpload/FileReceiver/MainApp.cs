using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using FUP;

namespace FileReceiver
{
	class MainApp
	{
		static void Main(string[] args)
		{
			if (args.Length < 1)
			{
				Console.WriteLine("사용법 : {0} <Directory>",
				   Process.GetCurrentProcess().ProcessName);
				return;
			}
			uint msgId = 0;

			string dir = args[0];
			if (Directory.Exists(dir) == false)
				Directory.CreateDirectory(dir);

			// 서버 포트는 5425입니다
			const int bindPort = 5425;
			TcpListener server = null;
			try
			{
				// IP 주소를 0으로 입력하면 127.0.01뿐 아니라 
				// OS에 할당되어 있는 어떤 주소로도 서버에 접속할 수 있습니다
				IPEndPoint localAddress =
				   new IPEndPoint(0, bindPort);

				server = new TcpListener(localAddress);
				server.Start();

				Console.WriteLine("파일 업로드 서버 시작... ");

				while (true)
				{
					TcpClient client = server.AcceptTcpClient();
					Console.WriteLine("클라이언트 접속 : {0} ",
					   ((IPEndPoint)client.Client.RemoteEndPoint).ToString());

					NetworkStream stream = client.GetStream();

					// 클라이언트가 보내온 파일 전송 요청 메시지를 수신합니다
					Message reqMsg = MessageUtil.Receive(stream);

					if (reqMsg.Header.MSGTYPE != CONSTANTS.REQ_FILE_SEND)
					{
						stream.Close();
						client.Close();
						continue;
					}

					BodyRequest reqBody = (BodyRequest)reqMsg.Body;

					Console.WriteLine(
					   "파일 업로드 요청이 왔습니다. 수락하시겠습니까? yes/no");
					string answer = Console.ReadLine();

					Message rspMsg = new Message();
					rspMsg.Body = new BodyResponse()
					{
						MSGID = reqMsg.Header.MSGID,
						RESPONSE = CONSTANTS.ACCEPTED
					};
					rspMsg.Header = new Header()
					{
						MSGID = msgId++,
						MSGTYPE = CONSTANTS.REP_FILE_SEND,
						BODYLEN = (uint)rspMsg.Body.GetSize(),
						FRAGMENTED = CONSTANTS.NOT_FRAGMENTED,
						LASTMSG = CONSTANTS.LASTMSG,
						SEQ = 0
					};

					if (answer != "yes")
					{
						// 거부한 경우
						rspMsg.Body = new BodyResponse()
						{
							MSGID = reqMsg.Header.MSGID,
							RESPONSE = CONSTANTS.DENIED
						};
						MessageUtil.Send(stream, rspMsg);
						stream.Close();
						client.Close();

						continue;
					}
					else
					{
						MessageUtil.Send(stream, rspMsg); // 승낙한 경우
					}

					Console.WriteLine("파일 전송을 시작합니다...");

					long fileSize = reqBody.FILESIZE;

					// 업로드 파일 스트림을 생성합니다
					string fileName = Path.GetFileName(Encoding.Default.GetString(reqBody.FILENAME));
					FileStream file = new FileStream(Path.Combine(dir, fileName), FileMode.Create);

					uint? dataMsgId = null;
					ushort prevSeq = 0;
					while ((reqMsg = MessageUtil.Receive(stream)) != null)
					{
						Console.Write("#");
						if (reqMsg.Header.MSGTYPE != CONSTANTS.FILE_SEND_DATA)
							break;

						if (dataMsgId == null)
							dataMsgId = reqMsg.Header.MSGID;
						else
						{
							if (dataMsgId != reqMsg.Header.MSGID)
								break;
						}

						if (prevSeq++ != reqMsg.Header.SEQ)
						{
							Console.WriteLine("{0}, {1}", prevSeq, reqMsg.Header.SEQ);
							break;
						}

						// 전송받은 스트림을 서버에서 생성한 파일에 기록합니다
						file.Write(reqMsg.Body.GetBytes(), 0, reqMsg.Body.GetSize());

						// 분할 메시지가 아니라면 반복을 한 번만 하고 빠져나옵니다.
						// 마지막 메시지면 반복문을 빠져나옵니다.
						if (reqMsg.Header.FRAGMENTED == CONSTANTS.NOT_FRAGMENTED)
							break;
						if (reqMsg.Header.LASTMSG == CONSTANTS.LASTMSG)
							break;
					}

					long recvFileSize = file.Length;
					file.Close();

					Console.WriteLine();
					Console.WriteLine("수신 파일 크기 : {0} bytes", recvFileSize);

					Message rstMsg = new Message();
					rstMsg.Body = new BodyResult()
					{
						MSGID = reqMsg.Header.MSGID,
						RESULT = CONSTANTS.SUCCESS
					};
					rstMsg.Header = new Header()
					{
						MSGID = msgId++,
						MSGTYPE = CONSTANTS.FILE_SEND_RES,
						BODYLEN = (uint)rstMsg.Body.GetSize(),
						FRAGMENTED = CONSTANTS.NOT_FRAGMENTED,
						LASTMSG = CONSTANTS.LASTMSG,
						SEQ = 0
					};

					// 파일 전송 요청에 담겨온 파일 크기와 실제 크기를 비교합니다
					if (fileSize == recvFileSize)
						MessageUtil.Send(stream, rstMsg);
					else
					{
						// 파일 크기에 이상이 있다면 실페 메시지를 보냅니다
						rstMsg.Body = new BodyResult()
						{
							MSGID = reqMsg.Header.MSGID,
							RESULT = CONSTANTS.FAIL
						};

						MessageUtil.Send(stream, rstMsg);
					}
					Console.WriteLine("파일 전송을 마쳤습니다.");

					stream.Close();
					client.Close();
				}
			}
			catch (SocketException e)
			{
				Console.WriteLine(e);
			}
			finally
			{
				server.Stop();
			}

			Console.WriteLine("서버를 종료합니다.");
		}
	}
}
