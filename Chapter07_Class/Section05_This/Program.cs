/* this 키워드 */
Employee pooh = new Employee();
pooh.SetName("Pooh");
pooh.SetPosition("Waiter");
Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}"); // Pooh Waiter

Employee tigger = new Employee();
tigger.SetName("Tigger");
tigger.SetPosition("Cleaner");
Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}"); // Tigger Cleaner

class Employee
{
	private string Name;
	private string Position;

	public void SetName(string Name)
	{
		this.Name = Name;
	}

	public string GetName()
	{
		return Name;
	}

	public void SetPosition(string Position)
	{
		this.Position = Position;
	}

	public string GetPosition()
	{
		return this.Position;
	}
}