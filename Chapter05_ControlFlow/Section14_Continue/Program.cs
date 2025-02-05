/* Continue 문 */
for (int i = 0; i < 10; i++)
{
	// 짝수 건너뛰기
	if (i % 2 == 0)
		continue;
	Console.WriteLine($"{i} : 홀수");
}