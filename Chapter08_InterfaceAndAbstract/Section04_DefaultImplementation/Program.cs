/* 인터페이스의 기본 구현 메소드 */
ILogger logger = new ConsoleLogger();
logger.WriteLog("System Up");
logger.WriteError("System Fail");

ConsoleLogger clogger = new ConsoleLogger();
clogger.WriteLog("System Up"); //  OK

// clogger.WriteError("System Fail"); // ConsoleLogger는 상속을 받지 않아 컴파일 에러

interface ILogger
{
	void WriteLog(string message);

	void WriteError(string error) // 새로운 메소드 추가
	{
		WriteLog($"Error: {error}");
	}
}

class ConsoleLogger : ILogger
{
	public void WriteLog(string message)
	{
		Console.WriteLine(
			$"{DateTime.Now.ToLocalTime()}, {message}");
	}
}