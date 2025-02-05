/* 객체 복사하기: 얕은 복사와 깊은 복사 */
// 얕은 복사
Console.WriteLine("Shallow Copy");
{
	MyClass source = new MyClass();
	source.MyField1 = 10;
	source.MyField2 = 20;

	MyClass target = source;
	target.MyField2 = 30;

	Console.WriteLine($"{source.MyField1} {source.MyField2}");
	Console.WriteLine($"{target.MyField1} {target.MyField2}");
}

// 깊은 복사
Console.WriteLine("Deep Copy");
{
	MyClass source = new MyClass();
	source.MyField1 = 10;
	source.MyField2 = 20;

	MyClass target = source.DeepCopy();
	target.MyField2 = 30;

	Console.WriteLine($"{source.MyField1} {source.MyField2}");
	Console.WriteLine($"{target.MyField1} {target.MyField2}");
}

class MyClass
{
	public int MyField1;
	public int MyField2;

	public MyClass DeepCopy()
	{
		MyClass newCopy = new MyClass();
		newCopy.MyField1 = MyField1;
		newCopy.MyField2 = MyField2;

		return newCopy;
	}
}