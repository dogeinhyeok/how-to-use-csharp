/* 상속으로 코드 재활용하기 */
Base a = new Base("a"); // a.Base()
a.BaseMethod(); // a.BaseMethod()

Derived b = new Derived("b"); // b.Base() b.Derived()
b.BaseMethod(); // b.BaseMethod()
b.DerivedMethod(); // b.DerivedMethod()

class Base
{
	protected string Name;
	public Base(string Name)
	{
		this.Name = Name;
		Console.WriteLine($"{this.Name}.Base()");
	}

	~Base()
	{
		Console.WriteLine($"{this.Name}.~Base()");
	}

	public void BaseMethod()
	{
		Console.WriteLine($"{Name}.BaseMethod()");
	}
}

class Derived : Base
{
	public Derived(string Name) : base(Name)
	{
		Console.WriteLine($"{this.Name}.Derived()");
	}

	~Derived()
	{
		Console.WriteLine($"{this.Name}.~Derived()");
	}

	public void DerivedMethod()
	{
		Console.WriteLine($"{Name}.DerivedMethod()");
	}
}