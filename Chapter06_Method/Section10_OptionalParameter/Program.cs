/* 선택적 인수 */
PrintProfile("중근");
PrintProfile("관순", "010-123-1234");
PrintProfile(name: "봉길");
PrintProfile(name: "중근", phone: "010-789-7890");

// phone 인수 생략 가능해짐
static void PrintProfile(string name, string phone = "")
{
	Console.WriteLine($"Name:{name}, Phone:{phone}");
}
