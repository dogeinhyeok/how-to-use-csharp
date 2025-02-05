/* 참조에 의한 매개변수 전달 */
int x = 3;
int y = 4;

Console.WriteLine($"x:{x}, y:{y}"); // x:3, y:4

Swap(ref x, ref y);

Console.WriteLine($"x:{x}, y:{y}"); // x:4, y:3

static void Swap(ref int a, ref int b)
{
	int temp = b;
	b = a;
	a = temp;
}