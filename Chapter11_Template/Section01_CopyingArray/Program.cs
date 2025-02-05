/* 일반화 메소드 */
int[] source = { 1, 2, 3, 4, 5 };
int[] target = new int[source.Length];

CopyArray<int>(source, target);

foreach (int element in target)
	Console.WriteLine(element); // 1,2,3,4,5

string[] source2 = { "하나", "둘", "셋", "넷", "다섯" };
string[] target2 = new string[source2.Length];

CopyArray<string>(source2, target2);

foreach (string element in target2)
	Console.WriteLine(element); // 하나,둘,셋,넷,다섯

// 일반화 메소드 선언
static void CopyArray<T>(T[] source, T[] target)
{
	for (int i = 0; i < source.Length; i++)
		target[i] = source[i];
}