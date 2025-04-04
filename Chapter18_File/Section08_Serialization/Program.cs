﻿/* 객체 직렬화 하기 */
using System.IO;
using System.Text.Json;

var fileName = "a.json";

using (Stream ws = new FileStream(fileName, FileMode.Create))
{
	NameCard nc = new NameCard()
	{
		Name = "박상현",
		Phone = "010-123-4567",
		Age = 33
	};

	// JsonSerializer를 통해 직렬화후, json 파일에 저장
	string jsonString = JsonSerializer.Serialize<NameCard>(nc);
	byte[] jsonBytes = System.Text.Encoding.UTF8.GetBytes(jsonString);
	ws.Write(jsonBytes, 0, jsonBytes.Length);
}

using (Stream rs = new FileStream(fileName, FileMode.Open))
{
	// Stream에서 값을 읽어온뒤, string형으로 값 불러오기
	byte[] jsonBytes = new byte[rs.Length];
	rs.Read(jsonBytes, 0, jsonBytes.Length);
	string jsonString = System.Text.Encoding.UTF8.GetString(jsonBytes);

	// jsonString 역직렬화해서 객체 인스턴스로 불러오기
	NameCard nc2 = JsonSerializer.Deserialize<NameCard>(jsonString);

	Console.WriteLine($"Name:  {nc2.Name}");
	Console.WriteLine($"Phone: {nc2.Phone}");
	Console.WriteLine($"Age:   {nc2.Age}");
}

class NameCard
{
	public string Name { get; set; }
	public string Phone { get; set; }
	public int Age { get; set; }
}
