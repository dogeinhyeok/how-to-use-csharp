/* 출력 전용 매개변수 */
int a = 20;
int b = 3;

Divide(a, b, out int c, out int d);

Console.WriteLine($"a:{a}, b:{b}, a/b={c}, a%b={d}"); // a:20, b:3, a/b=6, a%b=2

static void Divide(int a, int b, out int quotient, out int remainder)
{
	quotient = a / b;
	remainder = a % b;
}