/* switch 문 2 */
object obj = null;

Console.Write("문자를 입력해주세요: ");
string s = Console.ReadLine();
if (int.TryParse(s, out int out_i))
	obj = out_i;
else if (float.TryParse(s, out float out_f))
	obj = out_f;
else
	obj = s;

switch (obj)
{
	case int:
		Console.WriteLine($"{(int)obj}는 int 형식입니다.");
		break;
	case float f when f >= 0:
		Console.WriteLine($"{(float)obj}는 양의 float 형식입니다.");
		break;
	case float:
		Console.WriteLine($"{(float)obj}는 음의 float 형식입니다.");
		break;
	default:
		Console.Write($"{obj}(은)는 모르는 형식입니다.");
		break;
}