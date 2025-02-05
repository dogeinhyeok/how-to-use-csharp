/* 문 형식의 람다식 */
// 이 코드는 프로그램을 실행할 때 콘솔에서 입력합니다.
Concatenate concat =
(arr) =>
{
	string result = "";
	foreach (string s in arr)
		result += s;

	return result;
};

Console.WriteLine(concat(args));

delegate string Concatenate(string[] args);