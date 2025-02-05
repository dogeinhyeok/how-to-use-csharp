/* 값에 의한 매개변수 전달 */
int x = 3;
int y = 4;

Console.WriteLine($"x:{x}, y:{y}"); // x:3, y:4

Swap(x, y);

Console.WriteLine($"x:{x}, y:{y}"); // x:3, y:4

static void Swap(int a, int b)
{
	int temp = b;
	b = a;
	a = temp;
}