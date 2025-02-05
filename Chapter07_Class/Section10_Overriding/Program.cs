/* 오버라이딩과 다형성 */
Console.WriteLine("Creating ArmorSuite...");
ArmorSuite armorSuite = new ArmorSuite();
armorSuite.Initialize();

Console.WriteLine("\nCreating IronMan...");
ArmorSuite ironman = new IronMan();
ironman.Initialize();

Console.WriteLine("\nCreating WarMachine...");
ArmorSuite warmachine = new WarMachine();
warmachine.Initialize();

class ArmorSuite
{
	public virtual void Initialize()
	{
		Console.WriteLine("Armored");
	}
}

class IronMan : ArmorSuite
{
	public override void Initialize()
	{
		base.Initialize();
		Console.WriteLine("Repulsor Rays Armed");
	}
}

class WarMachine : ArmorSuite
{
	public override void Initialize()
	{
		base.Initialize();
		Console.WriteLine("Double-Barrel Cannons Armed");
		Console.WriteLine("Micro-Rocket Launcher Armed");
	}
}