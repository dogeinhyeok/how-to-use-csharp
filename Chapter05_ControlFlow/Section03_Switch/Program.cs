/* switch 문 */
Console.InputEncoding = System.Text.Encoding.UTF8;
Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.Write("요일을 입력하세요. (Sun, Mon, Tue, Wed, Thu, Fri, Sat) : ");
string day = Console.ReadLine();

switch (day)
{
	case "Sun":
		Console.WriteLine("Sunday");
		break;
	case "Mon":
		Console.WriteLine("Monday");
		break;
	case "Tue":
		Console.WriteLine("Tuesday");
		break;
	case "Wed":
		Console.WriteLine("Wednesday");
		break;
	case "Thu":
		Console.WriteLine("Thursday");
		break;
	case "Fri":
		Console.WriteLine("Friday");
		break;
	case "Sat":
		Console.WriteLine("Saturday");
		break;
	default:
		Console.WriteLine($"{day}는(은) 요일이 아닙니다.");
		break;
}