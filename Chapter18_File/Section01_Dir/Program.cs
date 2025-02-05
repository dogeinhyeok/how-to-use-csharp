/* 파일 정보와 디렉터리 정보 다루기 */
using System.Linq;
using System.IO;

// 인수를 입력시 해당 디렉토리, 미입력시 현재 디렉토리 목록 출력
string directory;
if (args.Length < 1)
	directory = ".";
else
	directory = args[0];

Console.WriteLine($"{directory} directory Info");
Console.WriteLine("- Directories :");

// Directory: 디렉토리의 생성, 삭제, 이동, 조회를 처리하는 정적 메소드를 제공합니다
// DirectoryInfo: Directoty 클래스와 하는 일은 동일하지만 정적 메소드 대신 인스턴스 메소드를 제공합니다
// Name: 디렉토리의 이름을 나타냅니다
// Attributes: 디렉토리의 속성(읽기 전용, 숨김, 시스템 파일, 디렉토리)을 나타냅니다
var directories = (from dir in Directory.GetDirectories(directory)
				   let info = new DirectoryInfo(dir)
				   select new
				   {
					   Name = info.Name,
					   Attributes = info.Attributes
				   }).ToList();

foreach (var d in directories)
	Console.WriteLine($"{d.Name} : {d.Attributes}");

Console.WriteLine("- Files :");

// File: 파일의 생성, 복사, 삭제, 이동, 조회를 처리하는 정적 메소드를 제공합니다
// FileInfo: File 클래스와 하는 일은 동일하지만 정적 메소드 대신 인스턴스 메소드를 제공합니다
// Name: 파일의 이름을 나타냅니다
// FileSize: 파일의 크기를 바이트 단위로 나타냅니다
// Attributes: 파일의 속성(읽기 전용, 숨김, 시스템 파일, 디렉토리 등)을 나타냅니다
var files = (from file in Directory.GetFiles(directory)
			 let info = new FileInfo(file)
			 select new
			 {
				 Name = info.Name,
				 FileSize = info.Length,
				 Attributes = info.Attributes
			 }).ToList();
foreach (var f in files)
	Console.WriteLine(
		$"{f.Name} : {f.FileSize} byte, {f.Attributes}");