/* 프로세스와 스레드 */
using System;
using System.Threading;

// 스레드의 인스턴스 생성
Thread t1 = new Thread(new ThreadStart(DoSomething));

// 스레드 시작
Console.WriteLine("Starting thread...");
t1.Start();

for (int i = 0; i < 5; i++)
{
	Console.WriteLine($"Main : {i}");
	// 현재 실행중인 스레드를 10 밀리초 일시정지시킵니다. (이 경우 메인스레드)
	Thread.Sleep(10);
}

// 스레드의 종료 대기
Console.WriteLine("Wating until thread stops...");
t1.Join();

Console.WriteLine("Finished");

// 스레드가 실행할 메소드
static void DoSomething()
{
	for (int i = 0; i < 5; i++)
	{
		Console.WriteLine($"DoSomething : {i}");
		Thread.Sleep(10);
	}
}