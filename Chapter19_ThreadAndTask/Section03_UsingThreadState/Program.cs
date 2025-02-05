/* 스레드의 일생과 상태 변화 */
// Unstarted: Thread.Start()메소드가 호출되기 전의 상태입니다
// Running: 스레드가 시작하여 동작 중인 상태를 나타냅니다
// Suspended: 스레드의 일시 중단 상태를 나타냅니다. 다시 Running 상태로 만들 수 있습니다
// WaitSleepJoin: 스레드의 블록된 상태를 나타냅니다
// Aborted: 스레드가 취소된 상태를 나타냅니다
// Stopped: 중지된 스레드의 상태를 나타냅니다. 실행 중인 메소드가 종료되면 이 상태가 됩니다
// Background: 스레드가 백그라운드로 동작하고 있음을 나타냅니다. 
// 		프로세스가 죽으면 백그라운드 스레드도 모두 죽습니다.
using System.Threading;

PrintThreadState(ThreadState.Running);

PrintThreadState(ThreadState.StopRequested);

PrintThreadState(ThreadState.SuspendRequested);

PrintThreadState(ThreadState.Background);

PrintThreadState(ThreadState.Unstarted);

PrintThreadState(ThreadState.Stopped);

PrintThreadState(ThreadState.WaitSleepJoin);

PrintThreadState(ThreadState.Suspended);

PrintThreadState(ThreadState.AbortRequested);

PrintThreadState(ThreadState.Aborted);

PrintThreadState(ThreadState.Aborted | ThreadState.Stopped);

// 비트 필드 형태로 상태 저장
static void PrintThreadState(ThreadState state)
{
	Console.WriteLine("{0,-16} : {1}", state, (int)state);
}