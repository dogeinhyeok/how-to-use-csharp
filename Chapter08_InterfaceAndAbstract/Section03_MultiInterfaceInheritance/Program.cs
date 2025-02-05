/* 여러 인터페이스, 한꺼번에 상속하기 */
FlyingCar car = new FlyingCar();
car.Run();
car.Fly();

IRunnable runnable = car as IRunnable;
runnable.Run();

IFlyable flyable = car as IFlyable;
flyable.Fly();

interface IRunnable
{
	void Run();
}

interface IFlyable
{
	void Fly();
}

class FlyingCar : IRunnable, IFlyable
{
	public void Run()
	{
		Console.WriteLine("Run! Run!");
	}

	public void Fly()
	{
		Console.WriteLine("Fly! Fly!");
	}
}