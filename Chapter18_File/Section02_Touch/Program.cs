/* 예제 프로그램: 디렉터리/파일 생성하기 */
using System.IO;

// 인수 값이 없으면 프로그램 종료
if (args.Length == 0)
{
	Console.WriteLine(
		"Usage : Touch.exe <Path> [Type:File/Directory]");
	return;
}

// 첫번째 인수를 파일경로로 설정하고 기본타입을 파일로 설정
string path = args[0];
string type = "File";

// 두번째 인수가 있으면 해당 인수를 타입으로 설정
if (args.Length > 1)
	type = args[1];

// 해당 경로에 파일이나 디렉토리가 존재하는지 검사합니다
if (File.Exists(path) || Directory.Exists(path))
{
	// 만약 해당 경로에 파일이나 디렉토리가 존재하면 시간만 갱신합니다
	if (type == "File")
		File.SetLastWriteTime(path, DateTime.Now);
	else if (type == "Directory")
		Directory.SetLastWriteTime(path, DateTime.Now);
	else
	{
		OnWrongPathType(path);
		return;
	}
	Console.WriteLine($"Updated {path} {type}");
}
// 해당 경로에 파일이나 디렉토리가 없으면 새로 생성합니다
else
{
	if (type == "File")
		File.Create(path).Close();
	else if (type == "Directory")
		Directory.CreateDirectory(path);
	else
	{
		OnWrongPathType(path);
		return;
	}

	Console.WriteLine($"Created {path} {type}");
}

// 잘못된 타입 입력시 오류를 출력합니다
static void OnWrongPathType(string type)
{
	Console.WriteLine($"{type} is wrong type");
	return;
}