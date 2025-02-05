/* lock 키워드로 쓰레드 동기화하기 */
using System.Threading;

Counter counter = new Counter();

Thread incThread = new Thread(
	new ThreadStart(counter.Increment));
Thread decThread = new Thread(
	new ThreadStart(counter.Decrement));

incThread.Start();
decThread.Start();

// 둘이 병렬로 함수가 실행되는데 걸리는 시간은 1000ms+ 입니다.
incThread.Join();
decThread.Join();

Console.WriteLine(counter.Count);

class Counter
{
	const int LOOP_COUNT = 1000;

	readonly object thisLock;

	private int count;
	public int Count
	{
		get { return count; }
	}

	public Counter()
	{
		thisLock = new object();
		count = 0;
	}

	// Increment 스레드는 count 값을 1000번 증가시킵니다.
	public void Increment()
	{
		int loopCount = LOOP_COUNT;
		while (loopCount-- > 0)
		{
			// 괄호안의 코드가 끝나기 전에 다른 스레드는 실행할 수 없습니다
			lock (thisLock)
			{
				count++;
			}
			Thread.Sleep(1);
		}
	}

	// Increment 스레드는 count 값을 1000번 감소시킵니다.
	public void Decrement()
	{
		int loopCount = LOOP_COUNT;
		while (loopCount-- > 0)
		{
			// 괄호안의 코드가 끝나기 전에 다른 스레드는 실행할 수 없습니다
			lock (thisLock)
			{
				count--;
			}
			Thread.Sleep(1);
		}
	}
}