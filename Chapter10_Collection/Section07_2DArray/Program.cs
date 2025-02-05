/* 2차원 배열 */
// 선언 방법 1
int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

for (int i = 0; i < arr.GetLength(0); i++)
{
	for (int j = 0; j < arr.GetLength(1); j++)
	{
		Console.Write($"[{i}, {j}] : {arr[i, j]} ");
	}
	Console.WriteLine();
}
Console.WriteLine();

// 선언 방법 2
int[,] arr2 = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };

for (int i = 0; i < arr2.GetLength(0); i++)
{
	for (int j = 0; j < arr2.GetLength(1); j++)
	{
		Console.Write($"[{i}, {j}] : {arr2[i, j]} ");
	}
	Console.WriteLine();
}
Console.WriteLine();

// 선언 방법 3
int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };

for (int i = 0; i < arr2.GetLength(0); i++)
{
	for (int j = 0; j < arr2.GetLength(1); j++)
	{
		Console.Write($"[{i}, {j}] : {arr3[i, j]} ");
	}
	Console.WriteLine();
}
Console.WriteLine();