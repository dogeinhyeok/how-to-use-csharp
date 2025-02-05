/* Monitor.Wait()와 Monitor.Pulse()로 하는 저수준 동기화 */
using System.Threading;

Counter counter = new Counter();

// 이 두 메소드는 서로 다른 스레드에서 동시에 실행되지만,
// Monitor.Wait()와 Monitor.Pulse()를 사용하여 
// 서로 교대로 count를 변경하도록 동기화하고 있습니다.
Thread incThread = new Thread(
	new ThreadStart(counter.Increase));
Thread decThread = new Thread(
	new ThreadStart(counter.Decrease));

incThread.Start();
decThread.Start();

incThread.Join();
decThread.Join();

Console.WriteLine(counter.Count);

class Counter
{
	const int LOOP_COUNT = 1000;

	// 클래스 안에 다음과 같이 동기화 객체 필드를 선언합니다
	readonly object thisLock;
	bool lockedCount = false;

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

	public void Increase()
	{
		int loopCount = LOOP_COUNT;

		while (loopCount-- > 0)
		{
			lock (thisLock)
			{
				// Decrease() 메소드에 의해 값이 감소하면 while문을 벗어납니다
				while (count > 0 || lockedCount == true)
					// Monitor.Wait()를 호출하여 스레드를 대기 상태로 만듭니다
					Monitor.Wait(thisLock);

				// Increase() 메소드가 count를 증가시키는 동안에는 
				// Decrease() 메소드는 대기 상태로 만들어져 count를 변경하지 않습니다.
				lockedCount = true;
				count++; // lockedCount는 count 변수에 동시에 접근하는 것을 방지하는 역할을 합니다
				lockedCount = false;

				// Monitor.Pulse()는 대기 중인 스레드 중 하나를 깨워 실행 상태로 만듭니다
				Monitor.Pulse(thisLock);
			}
		}
	}

	public void Decrease()
	{
		int loopCount = LOOP_COUNT;

		while (loopCount-- > 0)
		{
			lock (thisLock)
			{
				while (count < 0 || lockedCount == true)
					Monitor.Wait(thisLock);

				lockedCount = true;
				count--;
				lockedCount = false;

				Monitor.Pulse(thisLock);
			}
		}
	}
}