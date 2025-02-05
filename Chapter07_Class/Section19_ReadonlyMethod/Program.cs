/* 읽기 전용 메소드 */
ACSetting acs;
acs.currentInCelsius = 25;
acs.target = 25;

Console.WriteLine($"{acs.GetFahrenheit()}");
Console.WriteLine($"{acs.target}");

struct ACSetting
{
	public double currentInCelsius; // 현재 온도(C)
	public double target; // 희망 온도

	// 읽기 전용 메소드에서 객체의 필드를 바꿀 수 없음
	public readonly double GetFahrenheit()
	{
		// 객체의 필드를 바꿀 수 없어 컴파일 에러
		target = currentInCelsius * 1.8 + 32;
		return target;
	}
}