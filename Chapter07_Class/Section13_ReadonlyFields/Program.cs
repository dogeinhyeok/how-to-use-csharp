/* 읽기 전용 필드 */
// 읽기 전용 필드에는 할당할 수 없습니다.
Configuration configuration = new Configuration(100, 10);

class Configuration
{
	private readonly int min;
	private readonly int max;

	public Configuration(int v1, int v2)
	{
		min = v1;
		max = v2;
	}

	public void ChangeMax(int newMax)
	{
		max = newMax;
	}
}