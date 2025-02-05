/* 호출자 정보 애트리뷰트 */
using System.Runtime.CompilerServices;

Trace.WriteLine("즐거운 프로그래밍!");

public static class Trace
{
	// CallerLineNumber: 현재 메소드가 호출된 소스 파일 내의 행 번호를 나타냅니다
	// CallerFilePath: 현재 메소드가 호출된 소스 파일 경로를 나타냅니다
	// CallerMemberName: 현재 메소드가 호출한 메소드 또는 프로퍼티의 이름을 나타냅니다
	public static void WriteLine(string message,
		[CallerFilePath] string file = "",
		[CallerLineNumber] int line = 0,
		[CallerMemberName] string member = "")
	{
		Console.WriteLine(
			$"{file}(Line:{line}) {member}: {message}");
	}
}