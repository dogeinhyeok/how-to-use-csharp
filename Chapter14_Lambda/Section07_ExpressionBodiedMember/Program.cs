/* 식으로 이루어지는 멤버 */
using System.Collections.Generic;

FriendList obj = new FriendList();
obj.Add("Eeny");
obj.Add("Meeny");
obj.Add("Miny");
obj.Remove("Eeny");
obj.PrintAll();

class FriendList
{
	private List<string> list = new List<string>();

	// 식 본문 멤버: 코드를 간결하게 만드는데 사용됩니다
	public void Add(string name) => list.Add(name);
	public void Remove(string name) => list.Remove(name);
	public void PrintAll()
	{
		foreach (var s in list)
			Console.WriteLine(s);
	}

	public FriendList() => Console.WriteLine("FriendList()"); // 생성자
	~FriendList() => Console.WriteLine("~FriendList()"); // 종료자

	// public int Capacity => list.Capacity; // 읽기 전용

	public int Capacity // 속성
	{
		get => list.Capacity;
		set => list.Capacity = value;
	}

	// public string this[int index] => list[index]; // 읽기 전용
	public string this[int index]
	{
		get => list[index];
		set => list[index] = value;
	}
}