/* 프로퍼티 초기화를 강제하는 required 키워드 */
BirthdayInfo birth = new BirthdayInfo { Name = "서현", Birthday = new DateTime(1991, 6, 28) };

Console.WriteLine("Name : {0}", birth.Name);
Console.WriteLine("Birthday : {0}", birth.Birthday.ToShortDateString());
Console.WriteLine("Age : {0}", birth.Age);

class BirthdayInfo
{
	public required string Name { get; set; }
	public required DateTime Birthday { get; init; }

	public int Age
	{
		get
		{
			return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
		}
	}
}