﻿/* 코드의 비동기 실행 결과를 주는 Task<TResult> 클래스 */
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

// <from>~<to>사이의 정수에서 <tackCount>개의 Task로 계산하여 소수 찾기
long from = Convert.ToInt64(args[0]);
long to = Convert.ToInt64(args[1]);
int taskCount = Convert.ToInt32(args[2]);

// 소수찾기 함수 선언
Func<object, List<long>> FindPrimeFunc = (objRange) =>
{
	long[] range = (long[])objRange;
	List<long> found = new List<long>();

	for (long i = range[0]; i < range[1]; i++)
	{
		if (IsPrime(i))
			found.Add(i);
	}

	return found;
};

// Task 수에 따라 작업 분할하기
Task<List<long>>[] tasks = new Task<List<long>>[taskCount];
long currentFrom = from;
long currentTo = to / tasks.Length;
for (int i = 0; i < tasks.Length; i++)
{
	Console.WriteLine("Task[{0}] : {1} ~ {2}",
		i, currentFrom, currentTo);

	tasks[i] = new Task<List<long>>(FindPrimeFunc,
		new long[] { currentFrom, currentTo });
	currentFrom = currentTo + 1;

	if (i == tasks.Length - 2)
		currentTo = to;
	else
		currentTo = currentTo + (to / tasks.Length);
}

Console.WriteLine("Please press enter to start...");
Console.ReadLine();
Console.WriteLine("Started...");

DateTime startTime = DateTime.Now;

// 모든 작업 실행
foreach (Task<List<long>> task in tasks)
	task.Start();

List<long> total = new List<long>();

// 모든 작업이 끝날때까지 대기
foreach (Task<List<long>> task in tasks)
{
	task.Wait(); // 'Task'가 완료될 때까지 현재 스레드를 대기
	total.AddRange(task.Result.ToArray());
}
DateTime endTime = DateTime.Now;

// 작업 결과 출력
TimeSpan ellapsed = endTime - startTime;

Console.WriteLine("Prime number count between {0} and {1} : {2}",
											from, to, total.Count);
Console.WriteLine("Ellapsed time : {0}", ellapsed);

// 소수인지 검사하는 함수
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