/* 문자열 분할하기 */
string greeting = "Good morning.";

Console.WriteLine(greeting.Substring(0, 5)); // "Good"
Console.WriteLine(greeting.Substring(5)); // "morning."
Console.WriteLine();

string[] arr = greeting.Split(
	new string[] { " " }, StringSplitOptions.None);
Console.WriteLine("Word Count : {0}", arr.Length);

foreach (string element in arr)
	Console.WriteLine("{0}", element);