/* group by로 데이터 분류하기 */
using System.Linq;

Profile[] arrProfile =
{
	new Profile(){Name="정우성", Height=186},
	new Profile(){Name="김태희", Height=158},
	new Profile(){Name="고현정", Height=172},
	new Profile(){Name="이문세", Height=178},
	new Profile(){Name="하하", Height=171}
};

// group <범위변수> by <분류기준> into <그룹변수>: 데이터를 그룹화해주는 연산자입니다.
var listProfile = from profile in arrProfile
				  orderby profile.Height
				  group profile by profile.Height < 175 into g
				  select new { GroupKey = g.Key, Profiles = g };

// Group은 IGrouping 형식
foreach (var Group in listProfile)
{
	Console.WriteLine($"- 175cm 미만? : {Group.GroupKey}");

	// Group 안에 있는 프로파일 목록 출력
	foreach (var profile in Group.Profiles)
	{
		Console.WriteLine($"    {profile.Name}, {profile.Height}");
	}
}

class Profile
{
	public string Name { get; set; }
	public int Height { get; set; }
}