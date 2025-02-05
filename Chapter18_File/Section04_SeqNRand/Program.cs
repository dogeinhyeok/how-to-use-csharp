/* 파일의 임의 */
using System.IO;

Stream outStream = new FileStream("a.dat", FileMode.Create);
Console.WriteLine($"Position : {outStream.Position}");

// 0번 바이트에 "0x01"를 쓰고 다음 바이트로 이동
outStream.WriteByte(0x01);
Console.WriteLine($"Position : {outStream.Position}");

// 1번 바이트에 "0x02"를 쓰고 다음 바이트로 이동
outStream.WriteByte(0x02);
Console.WriteLine($"Position : {outStream.Position}");

// 2번 바이트에 "0x03"를 쓰고 다음 바이트로 이동
outStream.WriteByte(0x03);
Console.WriteLine($"Position : {outStream.Position}");

// 현재 위치로부터 5칸 이동 3번 바이트 -> 8번 바이트
outStream.Seek(5, SeekOrigin.Current);
Console.WriteLine($"Position : {outStream.Position}");

// 8번 바이트에 "0x04"를 쓰고 다음 바이트로 이동
outStream.WriteByte(0x04);
Console.WriteLine($"Position : {outStream.Position}");

outStream.Close();