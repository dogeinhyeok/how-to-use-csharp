/* 정적 필드와 메소드 */
Console.WriteLine($"Global.Count : {Global.Count}");

new ClassA();
new ClassA();
new ClassB();
new ClassB();

Console.WriteLine($"Global.Count : {Global.Count}");
class Global
{
	public static int Count = 0;
}

class ClassA
{
	public ClassA()
	{
		Global.Count++;
	}
}

class ClassB
{
	public ClassB()
	{
		Global.Count++;
	}
}