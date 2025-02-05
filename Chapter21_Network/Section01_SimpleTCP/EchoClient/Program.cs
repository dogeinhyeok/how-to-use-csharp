using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace EchoClient
{
	class MainApp
	{
		static void Main(string[] args)
		{
			// dotnet run 127.0.0.1 10000 127.0.0.1 Hello
			if (args.Length < 4)
			{
				Console.WriteLine(
					"사용법 : {0} <Bind IP> <Bind Port> <Server IP> <Message>",
					Process.GetCurrentProcess().ProcessName);
				return;
			}

			string bindIp = args[0];
			int bindPort = Convert.ToInt32(args[1]);
			string serverIp = args[2];
			const int serverPort = 5425;
			string message = args[3];

			try
			{
				// 클라이언트와 서버 IP 주소와 포트를 설정합니다
				IPEndPoint clientAddress =
					new IPEndPoint(IPAddress.Parse(bindIp), bindPort);
				IPEndPoint serverAddress =
					new IPEndPoint(IPAddress.Parse(serverIp), serverPort);

				Console.WriteLine("클라이언트: {0}, 서버:{1}",
					clientAddress.ToString(), serverAddress.ToString());

				// TcpListener를 생성하고 변수로 저장합니다
				TcpClient client = new TcpClient(clientAddress);

				// 서버가 수신 대기하고 있는 IP 주소와 포트 번호를 향해 연결 요청을 수행합니다
				client.Connect(serverAddress);

				// 보낼 메시지를 byte형으로 인코딩합니다
				byte[] data = System.Text.Encoding.Default.GetBytes(message);

				// TcpClient를 통해 NetworkStream 객체를 얻습니다
				NetworkStream stream = client.GetStream();

				// 보낼 데이터를 스트림을 통해 보냅니다
				stream.Write(data, 0, data.Length);

				Console.WriteLine("송신: {0}", message);

				data = new byte[256];

				string responseData = "";

				// 수신한 데이터를 읽어와 string형으로 변환합니다
				int bytes = stream.Read(data, 0, data.Length);
				responseData = Encoding.Default.GetString(data, 0, bytes);
				Console.WriteLine("수신: {0}", responseData);

				stream.Close();
				client.Close();
			}
			catch (SocketException e)
			{
				Console.WriteLine(e);
			}

			Console.WriteLine("클라이언트를 종료합니다.");
		}
	}
}
