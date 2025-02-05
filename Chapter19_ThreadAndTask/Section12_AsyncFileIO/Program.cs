/* .NET이 제공하는 비동기 API 맛보기 */
using System.IO;
using System.Threading.Tasks;

if (args.Length < 2)
{
	Console.WriteLine("Usage : AsyncFileIO <Source> <Destination>");
	return;
}

DoCopy(args[0], args[1]);

// 비동기로 처리하기 때문에 작업중 타이핑이 가능하다
Console.ReadLine();

// 파일 복사 후 복사한 파일 용량 반환.
// 비동기 라이브러리 사용시 async로 한정되어 있어야하며, 반환 형식이 Task형이어야 합니다
static async Task<long> CopyAsync(string FromPath, string ToPath)
{
	using (var fromStream = new FileStream(FromPath, FileMode.Open))
	{
		long totalCopied = 0;

		using (var toStream = new FileStream(ToPath, FileMode.Create))
		{
			byte[] buffer = new byte[1024];
			int nRead = 0;
			// 데이터를 읽고 쓰는 시점에 제어를 반환해 다른 코드가 실행할 수 있는 기회를 제공합니다
			while ((nRead =
				await fromStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
			{
				await toStream.WriteAsync(buffer, 0, nRead);
				totalCopied += nRead;
			}
		}

		return totalCopied;
	}
}

static async void DoCopy(string FromPath, string ToPath)
{
	// CopyAsync 메서드의 실행이 시작되고, 실행이 완료될 때까지
	// DoCopy 메서드의 실행은 일시 중단됩니다.
	long totalCopied = await CopyAsync(FromPath, ToPath);
	Console.WriteLine($"Copied Total {totalCopied} Bytes.");
}