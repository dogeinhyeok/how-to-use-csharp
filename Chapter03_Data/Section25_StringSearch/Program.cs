/* 문자열 다루기 */
string greeting = "Good Morning";

Console.WriteLine(greeting);
Console.WriteLine();

// IndexOf(): 현재 문자열 내에서 찾으려고 하는 지정된 문자 또는 문자열의 위치를 찾습니다.
Console.WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good")); // 0
Console.WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o')); // 1

// LastIndexOf(): 현재 문자열 내에서 찾으려고 하는 지정된 문자 또는 문자열의 위치를 뒤에서부터 찾습니다.
Console.WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good")); // 0
Console.WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf("o")); // 6

// StartsWith(): 현재 문자열이 지정된 문자열로 시작하는지를 평가합니다.
Console.WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good")); // True
Console.WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning")); // False

// EndsWith(): 현재 문자열이 지정된 문자열 끝나는지를 평가합니다.
Console.WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good")); // False
Console.WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning")); // True

// Contains(): 현재 문자열이 지정된 문자열을 포함하는지를 평가합니다.
Console.WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening")); // False
Console.WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning")); // True

// Replace(): 현재 문자열에서 지정된 문자열이 다른 지정된 문자열로 모두 바뀐 새 문자열을 반환합니다.
Console.WriteLine("Replaced 'Morning' with 'Evening': {0}",
	greeting.Replace("Morning", "Evening")); // Good Morning -> Good Evening