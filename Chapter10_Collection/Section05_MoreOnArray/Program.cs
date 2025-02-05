/* Array 클래스의 메소드와 프로퍼티를 활용하는 예제 */
int[] scores = new int[] { 80, 74, 81, 90, 34 };

// foreach 문을 사용하여 배열의 모든 요소를 출력합니다.
foreach (int score in scores)
	Console.Write($"{score} "); // 80 74 81 90 34
Console.WriteLine();

// Array.Sort 메서드를 사용하여 배열을 오름차순으로 정렬합니다.
Array.Sort(scores);

// Array.ForEach 메서드와 Action 델리게이트를 사용하여 배열의 모든 요소를 출력합니다.
Array.ForEach<int>(scores, new Action<int>(Print)); // 34 74 80 81 90
Console.WriteLine();

// 배열의 차원 수를 출력합니다.
Console.WriteLine($"Number of dimensions : {scores.Rank}"); // 1

// Array.BinarySearch 메서드를 사용하여 배열에서 특정 값(81)의 인덱스를 찾습니다.
Console.WriteLine($"Binary Search : 81 is at " +
	$"{Array.BinarySearch<int>(scores, 81)}"); // 3

// Array.IndexOf 메서드를 사용하여 배열에서 특정 값(90)의 인덱스를 찾습니다.
Console.WriteLine($"Linear Search : 90 is at " +
	$"{Array.IndexOf(scores, 90)}"); // 4

// Array.TrueForAll 메서드를 사용하여 배열의 모든 요소가 특정 조건(CheckPassed)을 만족하는지 확인합니다.
Console.WriteLine($"Everyone passed ? : " +
	$"{Array.TrueForAll<int>(scores, CheckPassed)}"); // False

// Array.FindIndex 메서드를 사용하여 배열에서 특정 조건(score < 60)을 만족하는 첫 번째 요소의 인덱스를 찾습니다.
int index = Array.FindIndex<int>(scores, (score) => score < 60); // 5
scores[index] = 61; // 찾은 인덱스의 값을 변경합니다.

// 다시 모든 요소가 조건을 만족하는지 확인합니다.
Console.WriteLine($"Everyone passed ? : " +
	$"{Array.TrueForAll<int>(scores, CheckPassed)}"); // True

// Array.GetLength 메서드를 사용하여 배열의 길이를 출력합니다.
Console.WriteLine("Old length of scores : " +
	$"{scores.GetLength(0)}");

// Array.Resize 메서드를 사용하여 배열의 크기를 변경합니다.
Array.Resize<int>(ref scores, 10);
Console.WriteLine($"New length of scores : {scores.Length}");

// 변경된 배열의 모든 요소를 출력합니다.
Array.ForEach<int>(scores, new Action<int>(Print));
Console.WriteLine();

// Array.Clear 메서드를 사용하여 배열의 특정 범위의 요소를 모두 0으로 설정합니다.
Array.Clear(scores, 3, 7);
Array.ForEach<int>(scores, new Action<int>(Print));
Console.WriteLine();

// 새로운 배열을 생성하고, Array.Copy 메서드를 사용하여 기존 배열의 일부를 새 배열로 복사합니다.
int[] sliced = new int[3];
Array.Copy(scores, 0, sliced, 0, 3);
Array.ForEach<int>(sliced, new Action<int>(Print));
Console.WriteLine();

// 점수가 60 이상인지 확인하는 메서드입니다.
static bool CheckPassed(int score)
{
	return score >= 60;
}

// 정수 값을 출력하는 메서드입니다.
static void Print(int value)
{
	Console.Write($"{value} ");
}
