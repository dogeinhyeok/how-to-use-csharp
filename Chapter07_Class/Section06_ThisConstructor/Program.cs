/* this() 생성자 */
MyClass a = new MyClass();
a.PrintFields(); // a: 5425, b: 0, c: 0
Console.WriteLine();

MyClass b = new MyClass();
b.PrintFields(); // a: 5425, b: 0, c: 0
Console.WriteLine();

MyClass c = new MyClass(10, 20); // a:5425, b:10, c:20
c.PrintFields();

class MyClass
{
	int a, b, c;

	public MyClass()
	{
		this.a = 5425;
		Console.WriteLine("MyClass()");
	}

	public MyClass(int b) : this()
	{
		this.b = b;
		Console.WriteLine($"MyClass({b})");
	}

	public MyClass(int b, int c) : this(b)
	{
		this.c = c;
		Console.WriteLine($"MyClass({b}, {c})");
	}

	public void PrintFields()
	{
		Console.WriteLine($"a:{a}, b:{b}, c:{c}");
	}
}
