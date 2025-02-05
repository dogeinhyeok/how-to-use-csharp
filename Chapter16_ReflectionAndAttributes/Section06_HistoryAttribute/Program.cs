/* 내가 만드는 애트리뷰트 */
Type type = typeof(MyClass);
Attribute[] attribues = Attribute.GetCustomAttributes(type);

Console.WriteLine("MyClass change history...");

foreach (Attribute a in attribues)
{
	History h = a as History;
	if (h != null)
		Console.WriteLine("Ver:{0}, Programmer:{1}, Changes:{2}",
			h.Version, h.Programmer, h.Changes);
}

// 애트리뷰트를 상속하여 자신만의 애트리뷰트를 만들 수 있습니다.
[System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)]
class History : System.Attribute
{
	private string programmer;

	public double Version
	{
		get;
		set;
	}

	public string Changes
	{
		get;
		set;
	}

	public History(string programmer)
	{
		this.programmer = programmer;
		Version = 1.0;
		Changes = "First release";
	}

	public string Programmer
	{
		get { return programmer; }
	}
}

[History("Sean", Version = 0.1, Changes = "2017-11-01 Created class stub")]
[History("Bob", Version = 0.2, Changes = "2020-12-03 Added Func() Method")]
class MyClass
{
	public void Func()
	{
		Console.WriteLine("Func()");
	}
}