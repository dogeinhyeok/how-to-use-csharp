/* 메소드 오버로딩 */
class Program
{
	static int Plus(int a, int b)
	{
		Console.WriteLine("Calling int Plus(int,int)...");
		return a + b;
	}

	static int Plus(int a, int b, int c)
	{
		Console.WriteLine("Calling int Plus(int,int,int)...");
		return a + b + c;
	}

	static double Plus(double a, double b)
	{
		Console.WriteLine("Calling double Plus(double,double)...");
		return a + b;
	}

	static double Plus(int a, double b)
	{
		Console.WriteLine("Calling double Plus(int, double)...");
		return a + b;
	}

	static void Main()
	{
		Console.WriteLine(Plus(1, 2));      // 3
		Console.WriteLine(Plus(1, 2, 3));   // 6
		Console.WriteLine(Plus(1.0, 2.4));  // 3.4
		Console.WriteLine(Plus(1, 2.4));    // 3.4
	}
}
