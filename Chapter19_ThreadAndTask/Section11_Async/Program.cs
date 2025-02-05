/* async 한정자와 await 연산자로 만드는 비동기 코드 */
using System.Threading.Tasks;

Caller();

Console.ReadLine(); // 프로그램 종료 방지

// async 한정자는 바로 다음 코드로 이동하도록 함 (Shoot & Forget)
async static void MyMethodAsync(int count)
{
	Console.WriteLine("C");
	Console.WriteLine("D");

	// await 연산자는 비동기 작업이 완료될 때까지 기다리는 동안 다른 작업을 수행할 수 있도록 합니다
	await Task.Run(async () =>
	{
		for (int i = 1; i <= count; i++)
		{
			Console.WriteLine($"{i}/{count} ...");
			await Task.Delay(100);
		}
	});

	Console.WriteLine("G");
	Console.WriteLine("H");
}

static void Caller()
{
	Console.WriteLine("A");
	Console.WriteLine("B");

	MyMethodAsync(3);

	Console.WriteLine("E");
	Console.WriteLine("F");
}