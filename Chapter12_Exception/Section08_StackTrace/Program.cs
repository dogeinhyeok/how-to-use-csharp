/* 예외 처리 다시 생각해보기 */
try
{
	int a = 1;
	Console.WriteLine(3 / --a);
}
catch (DivideByZeroException e)
{
	Console.WriteLine(e.StackTrace);
}