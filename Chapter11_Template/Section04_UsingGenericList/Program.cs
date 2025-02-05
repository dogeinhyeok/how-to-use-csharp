/* List<T> */
List<int> list = new List<int>();
for (int i = 0; i < 5; i++)
	list.Add(i);

foreach (int element in list)
	Console.Write($"{element} ");
Console.WriteLine(); // 0 1 2 3 4

list.RemoveAt(2);

foreach (int element in list)
	Console.Write($"{element} ");
Console.WriteLine(); // 0 1 3 4

list.Insert(2, 2); // 0 1 2 3 4

foreach (int element in list)
	Console.Write($"{element} ");
Console.WriteLine();