/* 확장 메소드 */
Console.WriteLine($"3^2 : {3.Square()}");
Console.WriteLine($"3^4 : {3.Power(4)}");
Console.WriteLine($"2^10 : {2.Power(10)}");

public static class IntegerExtension
{
	// Int 확장 메소드 1 (this 대상_형식 식별자, 매개변수_목록)
	public static int Square(this int myInt)
	{
		return myInt * myInt;
	}

	// Int 확장 메소드 2 (this 대상_형식 식별자, 매개변수_목록)
	public static int Power(this int myInt, int exponent)
	{
		int result = myInt;
		for (int i = 1; i < exponent; i++)
			result = result * myInt;

		return result;
	}
}