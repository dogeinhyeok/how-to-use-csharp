/* LINQ의 비밀과 LINQ 표준 연산자 */
using System.Linq;

Profile[] arrProfile =
{
	new Profile(){Name="정우성", Height=186},
	new Profile(){Name="김태희", Height=158},
	new Profile(){Name="고현정", Height=172},
	new Profile(){Name="이문세", Height=178},
	new Profile(){Name="하하", Height=171}
};

// 컴파일러가 LINQ 퀴리식은 다음 코드를 분석해 일반적인 메소드 호출 코드로 만들어냅니다.
/*
	var profiles =  from profile in arrProfile
                    where profile.Height < 175
                    orderby profile.Height
                    select new
                    {
                        Name = profile.Name,
                        InchHeight = profile.Height * 0.393
                    };

*/
var profiles = arrProfile.
				Where(profile => profile.Height < 175).
				OrderBy(profile => profile.Height).
				Select(profile =>
					new
					{
						Name = profile.Name,
						InchHeight = profile.Height * 0.393
					});

foreach (var profile in profiles)
	Console.WriteLine($"{profile.Name}, {profile.InchHeight}");

class Profile
{
	public string Name { get; set; }
	public int Height { get; set; }
}