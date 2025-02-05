/* 로컬 함수 */
Console.WriteLine(ToLowerString("Hello!"));
Console.WriteLine(ToLowerString("Good Morning."));
Console.WriteLine(ToLowerString("This is C#"));

static string ToLowerString(string input)
{
	var arr = input.ToCharArray();
	for (int i = 0; i < arr.Length; i++)
	{
		arr[i] = ToLowerChar(i);
	}

	// 로컬 함수 선언
	char ToLowerChar(int i)
	{
		if (arr[i] < 65 || arr[i] > 90)
			return arr[i];
		else
			return (char)(arr[i] + 32);
	}

	return new string(arr);
}