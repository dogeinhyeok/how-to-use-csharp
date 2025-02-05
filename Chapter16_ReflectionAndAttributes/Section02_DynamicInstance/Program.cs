/* 리플렉션을 이용해서 객체 생성하기 */
using System.Reflection;

Type type = Type.GetType("Profile");
MethodInfo methodInfo = type.GetMethod("Print");
PropertyInfo nameProperty = type.GetProperty("Name");
PropertyInfo phoneProperty = type.GetProperty("Phone");

// 리플렉션을 이용해 특정 형식의 인스턴스를 만들고 호출하는 법
object profile = Activator.CreateInstance(type, "박상현", "512-1234");
methodInfo.Invoke(profile, null); // 출력

// 리플렉션을 이용해 특정 형식의 인스턴스를 만들고 데이터를 할당하는 법
profile = Activator.CreateInstance(type);
nameProperty.SetValue(profile, "박찬호", null);
phoneProperty.SetValue(profile, "997-5511", null);

Console.WriteLine("{0}, {1}",
	nameProperty.GetValue(profile, null),
	phoneProperty.GetValue(profile, null)); // 출력

class Profile
{
	private string name;
	private string phone;
	public Profile()
	{
		name = ""; phone = "";
	}

	public Profile(string name, string phone)
	{
		this.name = name;
		this.phone = phone;
	}

	public void Print()
	{
		Console.WriteLine($"{name}, {phone}");
	}

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	public string Phone
	{
		get { return phone; }
		set { phone = value; }
	}
}