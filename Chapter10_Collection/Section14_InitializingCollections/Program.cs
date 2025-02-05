/* 컬렉션을 초기화하는 방법 */
using System.Collections;

int[] arr = { 123, 456, 789 };

ArrayList list = new ArrayList(arr); // 123, 456, 789
foreach (object item in list)
	Console.WriteLine($"ArrayList : {item}");
Console.WriteLine();

Stack stack = new Stack(arr); // 789, 456, 123
foreach (object item in stack)
	Console.WriteLine($"Stack : {item}");
Console.WriteLine();

Queue queue = new Queue(arr); // 123, 456, 789
foreach (object item in queue)
	Console.WriteLine($"Queue : {item}");
Console.WriteLine();

ArrayList list2 = new ArrayList() { 11, 22, 33 }; // 11, 22, 33
foreach (object item in list2)
	Console.WriteLine($"ArrayList2 : {item}");
Console.WriteLine();