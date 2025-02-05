/* 인터페이스의 프로퍼티 */
NamedValue name = new NamedValue()
{ Name = "이름", Value = "박상현" };

NamedValue height = new NamedValue()
{ Name = "키", Value = "177Cm" };

NamedValue weight = new NamedValue()
{ Name = "몸무게", Value = "90Kg" };

Console.WriteLine("{0} : {1}", name.Name, name.Value);
Console.WriteLine("{0} : {1}", height.Name, height.Value);
Console.WriteLine("{0} : {1}", weight.Name, weight.Value);

interface INamedValue
{
	// 인터페이스도 프로퍼티를 가질 수 있습니다.
	string Name
	{
		get;
		set;
	}

	string Value
	{
		get;
		set;
	}
}

class NamedValue : INamedValue
{
	// 반드시 구현해야합니다.
	public string Name
	{
		get;
		set;
	}

	public string Value
	{
		get;
		set;
	}
}