/* 덕 타이핑: 오리처럼 걷고 오리처럼 헤엄치며 오리처럼 꽉꽉거리는 새는 오리다 */
// dynamic 형식은 컴파일에 형식 검사를 하지 않음
dynamic[] arr = new dynamic[] { new Duck(), new Mallard(), new Robot() };

foreach (dynamic duck in arr)
{
	Console.WriteLine(duck.GetType());
	duck.Walk();
	duck.Swim();
	duck.Quack();

	Console.WriteLine();
}

class Duck
{
	public void Walk()
	{ Console.WriteLine(this.GetType() + ".Walk"); }

	public void Swim()
	{ Console.WriteLine(this.GetType() + ".Swim"); }

	public void Quack()
	{ Console.WriteLine(this.GetType() + ".Quack"); }
}

class Mallard : Duck
{ }

// 오리를 상속받지 않았지만 오리처럼 행동하니 덕 타이핑 관점에서는 오리로 인정함
class Robot
{
	public void Walk()
	{ Console.WriteLine("Robot.Walk"); }

	public void Swim()
	{ Console.WriteLine("Robot.Swim"); }

	public void Quack()
	{ Console.WriteLine("Robot.Quack"); }
}