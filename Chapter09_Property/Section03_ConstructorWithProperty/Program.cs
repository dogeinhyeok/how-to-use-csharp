/* 프로퍼티와 생성자 */
BirthdayInfo birth = new BirthdayInfo()
{
	// 프로퍼티를 이용한 객체 초기화
	Name = "서현",
	Birthday = new DateTime(1991, 6, 28)
};

Console.WriteLine("Name : {0}", birth.Name);
Console.WriteLine("Birthday : {0}", birth.Birthday.ToShortDateString());
Console.WriteLine("Age : {0}", birth.Age);

class BirthdayInfo
{
	public string Name
	{
		get;
		set;
	}

	public DateTime Birthday
	{
		get;
		set;
	}

	public int Age
	{
		get
		{
			return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year;
		}
	}
}