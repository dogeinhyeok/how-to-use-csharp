/* foreach가 가능한 객체 만들기 */
using System.Collections;

var obj = new MyEnumerator();
foreach (int i in obj) // foreach문이 GetEnumerator()를 호출하며 반복을 시작합니다.
	Console.WriteLine(i);

class MyEnumerator
{
	int[] numbers = { 1, 2, 3, 4 };

	// IEnumerator는 컬렉션 내의 요소를 순회하는 기능을 제공합니다.
	public IEnumerator GetEnumerator()
	{
		yield return numbers[0]; // 첫번째 요소를 반환하고 일시 중단합니다. 다음 반복을 시작할 때, 다음줄에서 계속됩니다.
		yield return numbers[1]; // 두번째 요소를 반환하고 일시 중단합니다. 다음 반복을 시작할 때, 다음줄에서 계속됩니다.
		yield return numbers[2]; // 세번째 요소를 반환하고 일시 중단합니다. 다음 반복을 시작할 때, 다음줄에서 계속됩니다.
		yield break; // 메서드의 실행을 완전히 중지하고, 더 이상 반환할 값이 없음을 나타냅니다.
		yield return numbers[3]; // 이 코드는 실행되지 않습니다.
	}
}
