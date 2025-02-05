/* 이벤트: 객체에 일어난 사건 알리기 */
MyNotifier notifier = new MyNotifier();
// 4. 작성한 이벤트 핸들러를 등록합니다
notifier.SomethingHappened += new EventHandler(MyHandler);

for (int i = 1; i < 30; i++)
{
	notifier.DoSomething(i);
}

// 3. 이벤트 핸들러를 작성합니다. 대리자와 형태가 일치해야합니다.
static void MyHandler(string message)
{
	Console.WriteLine(message);
}

class MyNotifier
{
	// 2. 선언한 대리자의 인스턴스를 event 한정자로 수식해서 선언합니다
	public event EventHandler SomethingHappened;
	public void DoSomething(int number)
	{
		int temp = number % 10;

		if (temp != 0 && temp % 3 == 0)
		{
			// 5. 이벤트가 발생하면 이벤트 핸들러가 호출됩니다.
			SomethingHappened(String.Format("{0} : 짝", number));
		}
	}
}

// 1. 대리자를 선언합니다
delegate void EventHandler(string message);