using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace EchoServer
{
	class MainApp
	{
		static void Main(string[] args)
		{
			// dotnet run 127.0.0.1
			if (args.Length < 1)
			{
				Console.WriteLine("사용법 : {0} <Bind IP>",
					Process.GetCurrentProcess().ProcessName);
				return;
			}

			string bindIp = args[0];
			const int bindPort = 5425;
			TcpListener server = null;
			try
			{
				// IPEndPoint는 IP 통신에 필요한 IP 주소와 포트를 나타냅니다
				IPEndPoint localAddress =
					new IPEndPoint(IPAddress.Parse(bindIp), bindPort);

				// TcpListener를 생성하고 변수로 저장합니다
				server = new TcpListener(localAddress);

				// server 객체는 연결 요청해오기를 기다리기 시작합니다
				server.Start();

				Console.WriteLine("메아리 서버 시작... ");

				while (true)
				{
					// 기다리던 연결 요청이 오면 TcpClient 형식의 객체를 반환합니다
					TcpClient client = server.AcceptTcpClient();
					Console.WriteLine("클라이언트 접속 : {0} ",
						((IPEndPoint)client.Client.RemoteEndPoint).ToString());

					// TcpClient를 통해 NetworkStream 객체를 얻습니다
					NetworkStream stream = client.GetStream();

					int length;
					string data = null;
					byte[] bytes = new byte[256];

					// Read()는 상대방이 보내온 데이터를 읽어 들입니다. 연결이 끊기면 0을 반환합니다
					while ((length = stream.Read(bytes, 0, bytes.Length)) != 0)
					{
						// 받아온 데이터를 string형으로 변환합니다
						data = Encoding.Default.GetString(bytes, 0, length);
						Console.WriteLine(String.Format("수신: {0}", data));

						// strging형을 다시 byte형으로 변환합니다
						byte[] msg = Encoding.Default.GetBytes(data);

						// Write()를 통해 상대방에게 메시지를 전송합니다
						stream.Write(msg, 0, msg.Length);
						Console.WriteLine(String.Format("송신: {0}", data));
					}

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
