﻿/* 스레드 임의로 종료하기 */
// Thread.Abort() 메소드는 .NET 프레임워크에서만 지원됩니다
using System.Threading;

SideTask task = new SideTask(100);
Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
t1.IsBackground = false;

Console.WriteLine("Starting thread...");
t1.Start();

Thread.Sleep(100);

Console.WriteLine("Aborting thread...");
t1.Abort();

Console.WriteLine("Wating until thread stops...");
t1.Join();

Console.WriteLine("Finished");

class SideTask
{
	int count;

	public SideTask(int count)
	{
		this.count = count;
	}

	public void KeepAlive()
	{
		try
		{
			while (count > 0)
			{
				Console.WriteLine($"{count--} left");
				Thread.Sleep(10);
			}
			Console.WriteLine("Count : 0");
		}
		catch (ThreadAbortException e)
		{
			Console.WriteLine(e);
			Thread.ResetAbort();
		}
		finally
		{
			Console.WriteLine("Clearing resource...");
		}
	}
}