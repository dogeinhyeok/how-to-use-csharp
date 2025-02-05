/* 인덱서 */
MyList list = new MyList();
for (int i = 0; i < 5; i++)
	list[i] = i;

for (int i = 0; i < list.Length; i++)
	Console.WriteLine(list[i]);

class MyList
{
	private int[] array;

	public MyList()
	{
		array = new int[3];
	}

	// 인덱서는 인덱스를 이용해서 객체 내의 데이터에 접근하게 해주는 프로퍼티
	public int this[int index]
	{
		get
		{
			return array[index];
		}

		set
		{
			if (index >= array.Length)
			{
				Array.Resize<int>(ref array, index + 1);
				Console.WriteLine($"Array Resized : {array.Length}");
			}

			array[index] = value;
		}
	}

	public int Length
	{
		get { return array.Length; }
	}
}
