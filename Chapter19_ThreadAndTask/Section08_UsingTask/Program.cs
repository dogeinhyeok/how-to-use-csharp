/* System.Threading.Tasks.Task 클래스 */
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

string srcFile = args[0];

// Task 클래스는 인스턴스를 생성할 때 매개변수 state가 포함된 Action 대리자를 넘겨받습니다
Action<object> FileCopyAction = (object state) =>
{
	String[] paths = (String[])state;
	File.Copy(paths[0], paths[1]);

	Console.WriteLine("TaskID:{0}, ThreadID:{1}, {2} was copied to {3}",
		Task.CurrentId, Thread.CurrentThread.ManagedThreadId,
		paths[0], paths[1]);
};

// Task를 생성한 후 필요한 시점에 Task.Start()를 호출하여 Task를 실행할 수 있습니다
Task t1 = new Task(
	FileCopyAction,
	new string[] { srcFile, srcFile + ".copy1" });
t1.Start(); // 'Task'가 별도의 스레드에서 비동기적으로 실행됩니다

// 이 방법을 사용하면 Task의 생성과 실행을 한 줄의 코드로 처리할 수 있습니다.
Task t2 = Task.Run(() =>
{
	FileCopyAction(new string[] { srcFile, srcFile + ".copy2" });
});

// 이 방법은 Task를 동기적으로 실행하려는 경우에 사용합니다.
Task t3 = new Task(
	FileCopyAction,
	new string[] { srcFile, srcFile + ".copy3" });
t3.RunSynchronously(); // 'Task'가 현재 스레드에서 동기적으로 실행됩니다.

t1.Wait();
t2.Wait();
t3.Wait();

var myTask = Task<List<int>>.Run(
	() =>
	{
		Thread.Sleep(1000);

		List<int> list = new List<int>();
		list.Add(3);
		list.Add(4);
		list.Add(5);

		return list;
	}
);

myTask.Wait();