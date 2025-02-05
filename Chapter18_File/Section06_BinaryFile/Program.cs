/* 이진 데이터 처리를 위한 BinaryWriter/BinaryReader */
using System.IO;

using (BinaryWriter bw =
	new BinaryWriter(
		new FileStream("a.dat", FileMode.Create)))
{
	// 순차적으로 바이너리에 값을 씁니다
	bw.Write(int.MaxValue);
	bw.Write("Good morning!");
	bw.Write(uint.MaxValue);
	bw.Write("안녕하세요!");
	bw.Write(double.MaxValue);
}

using BinaryReader br =
	new BinaryReader(
		new FileStream("a.dat", FileMode.Open));

// 순차적으로 바이너리을 쓴 순서 그대로 읽어와 값을 가져옵니다
Console.WriteLine($"File size : {br.BaseStream.Length} bytes");
Console.WriteLine($"{br.ReadInt32()}");
Console.WriteLine($"{br.ReadString()}");
Console.WriteLine($"{br.ReadUInt32()}");
Console.WriteLine($"{br.ReadString()}");
Console.WriteLine($"{br.ReadDouble()}");