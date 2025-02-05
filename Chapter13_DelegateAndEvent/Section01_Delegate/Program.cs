/* 대리자 */
Calculator Calc = new Calculator();
MyDelegate Callback;

Callback = new MyDelegate(Calc.Plus); // 메서드를 변수처럼 다룰 수 있다
Console.WriteLine(Callback(3, 4));

Callback = new MyDelegate(Calculator.Minus); // 메서드를 변수처럼 다룰 수 있다
Console.WriteLine(Callback(7, 5));

// 두 개의 int 매개변수를 받고 int를 반환하는 메서드를 참조하는 대리자입니다
delegate int MyDelegate(int a, int b);

class Calculator
{
	public int Plus(int a, int b)
	{
		return a + b;
	}

	public static int Minus(int a, int b)
	{
		return a - b;
	}
}