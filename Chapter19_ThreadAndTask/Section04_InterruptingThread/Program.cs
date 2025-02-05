/* 인터럽트: 스레드를 임의로 종료하는 다른 방법 */
using System.Security.Permissions;
using System.Threading;

SideTask task = new SideTask(100);
Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
t1.IsBackground = false;

Console.WriteLine("Starting thread...");
t1.Start();

Thread.Sleep(100);

// 스레드 취소
Console.WriteLine("Interrupting thread...");
t1.Interrupt();

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
			Console.WriteLine("Running thread isn't gonna be interrupted");
			Thread.Sleep(100);

			while (count > 0)
			{
				Console.WriteLine($"{count--} left");

				Console.WriteLine("Entering into WaitJoinSleep State...");
				Thread.Sleep(10); // 여기서 스레드가 일시 중지 상태가 됨
								  // 이때, 't1.Interrupt();'가 호출됨
			}
			Console.WriteLine("Count : 0");
		}
		catch (ThreadInterruptedException e)
		{
			Console.WriteLine(e);
		}
		finally
		{
			Console.WriteLine("Clearing resource...");
		}
	}
}