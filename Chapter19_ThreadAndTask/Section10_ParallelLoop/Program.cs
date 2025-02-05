/* 손쉬운 병렬 처리를 가능케 하는 Parallel 클래스 */
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

long from = Convert.ToInt64(args[0]);
long to = Convert.ToInt64(args[1]);

Console.WriteLine("Please press enter to start...");
Console.ReadLine();
Console.WriteLine("Started...");

DateTime startTime = DateTime.Now;
List<long> total = new List<long>();

// <from>~<to>까지 병렬로 처리하기
Parallel.For(from, to, (long i) =>
{
	if (IsPrime(i))
		lock (total)
			total.Add(i);

});

// 출력 처리
DateTime endTime = DateTime.Now;

TimeSpan ellapsed = endTime - startTime;

Console.WriteLine("Prime number count between {0} and {1} : {2}",
											from, to, total.Count);
Console.WriteLine("Ellapsed time : {0}", ellapsed);

// 소수 찾기 함수
static bool IsPrime(long number)
{
	if (number < 2)
		return false;

	if (number % 2 == 0 && number != 2)
		return false;

	for (long i = 2; i < number; i++)
	{
		if (number % i == 0)
			return false;
	}

	return true;
}
