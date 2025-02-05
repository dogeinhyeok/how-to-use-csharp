/* System.IO.Stream 클래스 */
long someValue = 0x123456789ABCDEF0;
Console.WriteLine("{0,-1} : 0x{1:X16}", "Original Data", someValue); // Original Data : 0x123456789ABCDEF0

// 1. 파일 스트림 생성
Stream outStream = new FileStream("a.dat", FileMode.Create);
// 2. long 형식을 byte 배열로 변환
byte[] wBytes = BitConverter.GetBytes(someValue);

Console.Write("{0,-13} : ", "Byte array");

// Byte array: F0 DE BC 9A 78 56 34 12
foreach (byte b in wBytes)
	Console.Write("{0:X2} ", b);
Console.WriteLine();

// 3. 변환한 byte 배열을 파일 스트림을 통해 파일에 기록
outStream.Write(wBytes, 0, wBytes.Length);
// 4. 파일 스트림 닫기
outStream.Close();

// 1. 파일 스트림 생성
Stream inStream = new FileStream("a.dat", FileMode.Open);

// 2. rbytes의 길이만큼(8바이트) 데이터를 읽어 rBytes에 저장
byte[] rbytes = new byte[8];
int i = 0;
inStream.Read(rbytes, 0, rbytes.Length);

long readValue = BitConverter.ToInt64(rbytes, 0);

Console.WriteLine("{0,-13} : 0x{1:X16} ", "Read Data", readValue); // Read Data: 0x123456789ABCDEF0
inStream.Close();