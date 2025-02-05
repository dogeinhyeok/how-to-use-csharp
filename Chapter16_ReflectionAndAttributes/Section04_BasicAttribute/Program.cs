/* 애트리뷰트: 컴파일러에게 코드에 대한 부가 정보를 입력할 수 있습니다 */
MyClass obj = new MyClass();

obj.OldMethod();
obj.NewMethod();

class MyClass
{
	// 대괄호 안에 애트리뷰트의 이름을 넣어 사용하면 됩니다.
	[Obsolete("OldMethod는 폐기되었습니다. NewMethod()를 이용하세요.")]
	public void OldMethod()
	{
		Console.WriteLine("I'm old");
	}

	public void NewMethod()
	{
		Console.WriteLine("I'm new");
	}
}