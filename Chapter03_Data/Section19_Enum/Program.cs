﻿/* 열거 형식 */
internal class Program
{

	enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }
	private static void Main(string[] args)
	{
		Console.WriteLine((int)DialogResult.YES);
		Console.WriteLine((int)DialogResult.NO);
		Console.WriteLine((int)DialogResult.CANCEL);
		Console.WriteLine((int)DialogResult.CONFIRM);
		Console.WriteLine((int)DialogResult.OK);
	}
}