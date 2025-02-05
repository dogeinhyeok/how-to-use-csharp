/* 메소드 숨기기 */
Base baseObj = new Base();
baseObj.MyMethod(); // Base.MyMethod()

Derived derivedObj = new Derived();
derivedObj.MyMethod(); // Derived.MyMethod()

Base baseOrDerived = new Derived();
baseOrDerived.MyMethod(); // Base.MyMethod()

class Base
{
	public void MyMethod()
	{
		Console.WriteLine("Base.MyMethod()");
	}
}

class Derived : Base
{
	// Base.MyMethod()를 감추고 Derived 클래스에서 구현된 MyMethod()만 노출
	public new void MyMethod()
	{
		Console.WriteLine("Derived.MyMethod()");
	}
}