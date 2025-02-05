/* switch 식: 식(Expression)은 연산자와 연산자의 조합입니다. */
Console.WriteLine("점수를 입력하세요.");
int score = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("재수강인가요? (y/n)");
string line = Console.ReadLine();
bool repeated = line == "y" ? true : false;

// switch 식 사용법
string grade = (int)(Math.Truncate(score / 10.0) * 10) switch
{
	90 when repeated == true => "B+",
	90 => "A",
	80 => "B",
	70 => "C",
	60 => "D",
	_ => "F"
};

Console.WriteLine($"학점 : {grade}");