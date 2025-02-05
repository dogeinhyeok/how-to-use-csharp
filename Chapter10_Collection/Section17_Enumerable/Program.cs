/* IEnumerator 인터페이스 */
using System.Collections;

MyList list = new MyList();
for (int i = 0; i < 5; i++)
	list[i] = i; // {0,1,2,3,4}

foreach (int e in list)
	Console.WriteLine(e);

// IEnumerable: foreach 루프에서 사용될 수 있도록 하는 인터페이스입니다.
//     GetEnumerator() 등의 메서드를 제공해야 합니다.
// IEnumerator: 컬렉션의 요소를 하나씩 순회하는 방법을 제공하는 인터페이스입니다. 
//     MoveNext(), Reset(), Current 등의 메서드를 제공해야 합니다.
class MyList : IEnumerable, IEnumerator
{
	private int[] array;
	int position = -1;

	public MyList()
	{
		array = new int[3];
	}

	// 인덱서
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

	// IEnumerator로부터 상속받은 Current 프로퍼티는 현재 위치의 요소를 반환합니다
	public object Current
	{
		get
		{
			return array[position];
		}
	}

	// IEnumerator로부터 상속받은 MoveNext() 메소드, 다음 위치의 요소로 이동합니다
	public bool MoveNext()
	{
		if (position == array.Length - 1)
		{
			Reset();
			return false;
		}

		position++;
		return (position < array.Length);
	}

	// IEnumerator로부터 상속받은 Reset() 메소드, 위치를 초기화합니다
	public void Reset()
	{
		position = -1;
	}

	// IEnumerable 멤버 함수 구현
	public IEnumerator GetEnumerator()
	{
		return this;
	}
}
