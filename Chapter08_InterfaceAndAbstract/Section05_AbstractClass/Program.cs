/* 추상 클래스 */
AbstractBase obj = new Derived();
obj.AbstractMethodA();
obj.PublicMethodA();

abstract class AbstractBase
{
	protected void PrivateMethodA()
	{
		Console.WriteLine("AbstractBase.PrivateMethodA()");
	}

	public void PublicMethodA()
	{
		Console.WriteLine("AbstractBase.PublicMethodA()");
	}

	public abstract void AbstractMethodA(); // 상속 받아서 구현해야함
}

class Derived : AbstractBase
{
	public override void AbstractMethodA()
	{
		Console.WriteLine("Derived.AbstractMethodA()");
		PrivateMethodA();
	}
}
