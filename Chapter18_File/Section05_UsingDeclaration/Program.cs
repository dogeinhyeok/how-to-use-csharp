/* 실수를 줄여주는 using 선언 */
using System.IO;
using FS = System.IO.FileStream;

long someValue = 0x123456789ABCDEF0;
Console.WriteLine("{0,-1} : 0x{1:X16}", "Original Data", someValue);

// 1. 파일 스트림 열기, using 선언 스타일로 자원의 수명 조절 가능
using (Stream outStream = new FS("a.dat", FileMode.Create))
{
	// 2. someValue을 byte 배열로 변환
	byte[] wBytes = BitConverter.GetBytes(someValue);

	Console.Write("{0,-13} : ", "Byte array");

	foreach (byte b in wBytes)
		Console.Write("{0:X2} ", b);
	Console.WriteLine();

	// 3. 변환한 byte 배열을 파일 스트림을 통해 파일에 기록
	outStream.Write(wBytes, 0, wBytes.Length);

	// using 선언을 통해 생성된 객체는 코드 블록이 끝나면 outStream.Dispose() 호출
}

using Stream inStream = new FS("a.dat", FileMode.Open);
byte[] rbytes = new byte[8];

int i = 0;
while (inStream.Position < inStream.Length)
	rbytes[i++] = (byte)inStream.ReadByte();

long readValue = BitConverter.ToInt64(rbytes, 0);

Console.WriteLine("{0,-13} : 0x{1:X16} ", "Read Data", readValue);