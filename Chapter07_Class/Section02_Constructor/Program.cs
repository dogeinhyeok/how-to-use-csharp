/* 객체의 삶과 죽음에 대하여: 생성자와 종료자 */
Cat kitty = new Cat("키티", "하얀색");
kitty.Meow();
Console.WriteLine($"{kitty.Name} : {kitty.Color}");

Cat nero = new Cat("네로", "검은색");
nero.Meow();
Console.WriteLine($"{nero.Name} : {nero.Color}");

class Cat
{
	public Cat()
	{
		Name = "";
		Color = "";
	}

	public Cat(string _Name, string _Color)
	{
		Name = _Name;
		Color = _Color;
	}

	~Cat()
	{
		Console.WriteLine($"{Name} : 잘가");
	}

	public string Name;
	public string Color;

	public void Meow()
	{
		Console.WriteLine($"{Name} : 야옹");
	}
}