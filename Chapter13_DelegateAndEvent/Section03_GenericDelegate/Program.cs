﻿/* 일반화 대리자 */
int[] array = { 3, 7, 4, 2, 10 };

Console.WriteLine("Sorting ascending...");
BubbleSort<int>(array, new Compare<int>(AscendCompare)); // int 오름차순 정렬

for (int i = 0; i < array.Length; i++)
	Console.Write($"{array[i]} ");

string[] array2 = { "abc", "def", "ghi", "jkl", "mno" };

Console.WriteLine("\nSorting descending...");
BubbleSort<string>(array2, new Compare<string>(DescendCompare)); // string 내림차순 정렬

for (int i = 0; i < array2.Length; i++)
	Console.Write($"{array2[i]} ");

Console.WriteLine();

static int AscendCompare<T>(T a, T b) where T : IComparable<T>
{
	return a.CompareTo(b);
}

static int DescendCompare<T>(T a, T b) where T : IComparable<T>
{
	return a.CompareTo(b) * -1;
}

static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
{
	int i = 0;
	int j = 0;
	T temp;

	for (i = 0; i < DataSet.Length - 1; i++)
	{
		for (j = 0; j < DataSet.Length - (i + 1); j++)
		{
			if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
			{
				temp = DataSet[j + 1];
				DataSet[j + 1] = DataSet[j];
				DataSet[j] = temp;
			}
		}
	}
}

delegate int Compare<T>(T a, T b);