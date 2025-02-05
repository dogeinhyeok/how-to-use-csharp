/* 텍스트 파일 처리를 위한 StreamWriter/StreamReader */
using System.IO;

using (StreamWriter sw =
	new StreamWriter(
		new FileStream("a.txt", FileMode.Create)))
{
	// 순차적으로 텍스트로 값을 쓰기
	sw.WriteLine(int.MaxValue);
	sw.WriteLine("Good morning!");
	sw.WriteLine(uint.MaxValue);
	sw.WriteLine("안녕하세요!");
	sw.WriteLine(double.MaxValue);
}

using (StreamReader sr =
	new StreamReader(
		new FileStream("a.txt", FileMode.Open)))
{
	Console.WriteLine($"File size : {sr.BaseStream.Length} bytes");

	while (sr.EndOfStream == false)
	{
		// 순차적으로 텍스트 출력
		Console.WriteLine(sr.ReadLine());
	}
}