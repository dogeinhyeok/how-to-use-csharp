using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FUP
{
	// 파일 전송 요청 메시지(0x01)에 사용할 본문 클래스입니다.
	public class BodyRequest : ISerializable
	{
		public long FILESIZE; // 전송할 파일 크기
		public byte[] FILENAME; // 전송할 파일 이름

		public BodyRequest() { }
		public BodyRequest(byte[] bytes)
		{
			FILESIZE = BitConverter.ToInt64(bytes, 0);
			FILENAME = new byte[bytes.Length - sizeof(long)];
			Array.Copy(bytes, sizeof(long), FILENAME, 0, FILENAME.Length);
		}

		public byte[] GetBytes()
		{
			byte[] bytes = new byte[GetSize()];
			byte[] temp = BitConverter.GetBytes(FILESIZE);
			Array.Copy(temp, 0, bytes, 0, temp.Length);
			Array.Copy(FILENAME, 0, bytes, temp.Length, FILENAME.Length);

			return bytes;
		}

		public int GetSize()
		{
			return sizeof(long) + FILENAME.Length;
		}
	}

	// 파일 전송 요청에 대한 응답(0x02)에 사용할 본문 클래스입니다.
	public class BodyResponse : ISerializable
	{
		public uint MSGID; // 파일 전송 요청 메시지(0x01)의 메시지 식별 번호
		public byte RESPONSE; // 파일 전송 승인 여부 (0x0, 0x1)
		public BodyResponse() { }
		public BodyResponse(byte[] bytes)
		{
			MSGID = BitConverter.ToUInt32(bytes, 0);
			RESPONSE = bytes[4];
		}

		public byte[] GetBytes()
		{
			byte[] bytes = new byte[GetSize()];
			byte[] temp = BitConverter.GetBytes(MSGID);
			Array.Copy(temp, 0, bytes, 0, temp.Length);
			bytes[temp.Length] = RESPONSE;

			return bytes;
		}

		public int GetSize()
		{
			return sizeof(uint) + sizeof(byte);
		}
	}

	// 실제 파일을 전송하는 메시지(0x03)에 사용할 본문 클래스입니다.
	public class BodyData : ISerializable
	{
		public byte[] DATA; // 파일 내용

		public BodyData(byte[] bytes)
		{
			DATA = new byte[bytes.Length];
			bytes.CopyTo(DATA, 0);
		}

		public byte[] GetBytes()
		{
			return DATA;
		}

		public int GetSize()
		{
			return DATA.Length;
		}
	}

	// 파일 전송 결과 메시지(0x04)에 사용할 본문 클래스입니다.
	public class BodyResult : ISerializable
	{
		public uint MSGID; // 파일 전송 데이터(0x03)의 식별 번호
		public byte RESULT; // 파일 전송 성공 여부

		public BodyResult() { }
		public BodyResult(byte[] bytes)
		{
			MSGID = BitConverter.ToUInt32(bytes, 0);
			RESULT = bytes[4];
		}
		public byte[] GetBytes()
		{
			byte[] bytes = new byte[GetSize()];
			byte[] temp = BitConverter.GetBytes(MSGID);
			Array.Copy(temp, 0, bytes, 0, temp.Length);
			bytes[temp.Length] = RESULT;

			return bytes;
		}

		public int GetSize()
		{
			return sizeof(uint) + sizeof(byte);
		}
	}
}