/* 두 데이터 원본을 연결하는 join: 특정 필드의 값을 비교하여 일치하는 데이터끼리 연결합니다. */
using System.Linq;

Profile[] arrProfile =
{
	new Profile(){Name="정우성", Height=186},
	new Profile(){Name="김태희", Height=158},
	new Profile(){Name="고현정", Height=172},
	new Profile(){Name="이문세", Height=178},
	new Profile(){Name="하하", Height=171}
};

Product[] arrProduct =
{
	new Product(){Title="비트", Star="정우성"},
	new Product(){Title="CF 다수", Star="김태희"},
	new Product(){Title="아이리스", Star="김태희"},
	new Product(){Title="모래시계", Star="고현정"},
	new Product(){Title="Solo 예찬", Star="이문세"}
};

// join <기준-데이터> in <연결-대상-데이터> on <동등-변수-1> equals <동등-변수-2>:
//  	내부조인, 두 데이터 원본 사이에서 일치하는 데이터들만 연결한 후 반환 (교집합)
/*
	이름:정우성, 작품:비트, 키:186cm
	이름:김태희, 작품:CF 다수, 키:158cm
	이름:김태희, 작품:아이리스, 키:158cm
	이름:고현정, 작품:모래시계, 키:172cm
	이름:이문세, 작품:Solo 예찬, 키:178cm
*/
var listProfile =
	from profile in arrProfile
	join product in arrProduct on profile.Name equals product.Star
	select new
	{
		Name = profile.Name,
		Work = product.Title,
		Height = profile.Height
	};

Console.WriteLine("--- 내부 조인 결과 ---");
foreach (var profile in listProfile)
{
	Console.WriteLine("이름:{0}, 작품:{1}, 키:{2}cm",
		profile.Name, profile.Work, profile.Height);
}

// join <기준 데이터> in <연결 대상 데이터> on <동등 변수 1> equals <동등 변수 2>:
//  	외부조인, 두 데이터 원본을 모두 포함시켜 연결한 후 반환 (합집합)
/*
	이름:정우성, 작품:비트, 키:186cm
	이름:김태희, 작품:CF 다수, 키:158cm
	이름:김태희, 작품:아이리스, 키:158cm
	이름:고현정, 작품:모래시계, 키:172cm
	이름:이문세, 작품:Solo 예찬, 키:178cm
	이름:하하, 작품:그런거 없음, 키:171cm
*/
listProfile =
	// 1. join 절을 이용해서 조인 결과를 임시 컬렉션에 저장합니다
	// 2. 이 임시 컬렉션에 DefaultIfEmpty 연산을 수행해서 비어 있는 조인 결과에 빈값을 채워 넣습니다
	// 3. DefaultEmpty 연산을 거친 임시 컬렉션에서 from 절을 통해 범위 변수를 뽑아냅니다.
	// 4. 이 범위 변수와 기준 데이터 원본에서 뽑아낸 범위 변수를 이용해서 결과를 추출해냅니다.
	from profile in arrProfile
	join product in arrProduct on profile.Name equals product.Star into ps
	from sub_product in ps.DefaultIfEmpty(new Product() { Title = "-" })
	select new
	{
		Name = profile.Name,
		Work = sub_product.Title,
		Height = profile.Height
	};

Console.WriteLine();
Console.WriteLine("--- 외부 조인 결과 ---");
foreach (var profile in listProfile)
{
	Console.WriteLine("이름:{0}, 작품:{1}, 키:{2}cm",
		profile.Name, profile.Work, profile.Height);
}

class Profile
{
	public string Name { get; set; }
	public int Height { get; set; }
}

class Product
{
	public string Title { get; set; }
	public string Star { get; set; }
}