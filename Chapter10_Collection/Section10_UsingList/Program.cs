/* 컬렉션 맛보기: ArrayList */
using System.Collections;

ArrayList list = new ArrayList();
for (int i = 0; i < 5; i++)
	list.Add(i);

foreach (object obj in list)
	Console.Write($"{obj} ");
Console.WriteLine(); // 0 1 2 3 4

list.RemoveAt(2);

foreach (object obj in list)
	Console.Write($"{obj} ");
Console.WriteLine(); // 0 1 3 4

list.Insert(2, 2);

foreach (object obj in list)
	Console.Write($"{obj} ");
Console.WriteLine(); // 0 1 2 3 4

list.Add("abc");
list.Add("def");

for (int i = 0; i < list.Count; i++)
	Console.Write($"{list[i]} ");
Console.WriteLine(); // 0 1 2 3 4 abc def