/* 예외 던지기 2 */
try
{
	int? a = null;
	int b = a ?? throw new ArgumentNullException(); // 값이 null일 수 없습니다
}
catch (ArgumentNullException e)
{
	Console.WriteLine(e);
}

try
{
	int[] array = new[] { 1, 2, 3 };
	int index = 4;
	int value = array[
		index > 0 && index < 3
		? index : throw new IndexOutOfRangeException() // 인덱스가 배열 범위를 벗어났습니다
	];
}
catch (IndexOutOfRangeException e)
{
	Console.WriteLine(e);
}