﻿/* 클래스의 선언과 객체의 생성 */
Cat kitty = new Cat();
kitty.Color = "하얀색";
kitty.Name = "키티";
kitty.Meow();
Console.WriteLine($"{kitty.Name} : {kitty.Color}");

Cat nero = new Cat();
nero.Color = "검은색";
nero.Name = "네로";
nero.Meow();
Console.WriteLine($"{nero.Name} : {nero.Color}");

class Cat
{
	public string Name;
	public string Color;

	public void Meow()
	{
		Console.WriteLine($"{Name} : 야옹");
	}
}