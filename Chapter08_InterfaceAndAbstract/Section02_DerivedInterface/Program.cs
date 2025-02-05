/* 인터페이스를 상속하는 인터페이스 */
IFormattableLogger logger = new ConsoleLogger();
logger.WriteLog("The world is not flat.");
logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);

interface ILogger
{
	void WriteLog(string message);
}

interface IFormattableLogger : ILogger
{
	void WriteLog(string format, params Object[] args);
}

class ConsoleLogger : IFormattableLogger
{
	public void WriteLog(string message)
	{
		Console.WriteLine("{0} {1}",
			DateTime.Now.ToLocalTime(), message);
	}

	public void WriteLog(string format, params Object[] args)
	{
		string message = string.Format(format, args);
		Console.WriteLine("{0} {1}",
			DateTime.Now.ToLocalTime(), message);
	}
}