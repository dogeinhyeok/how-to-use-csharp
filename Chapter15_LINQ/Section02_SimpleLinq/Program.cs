/* Linq 사용법 */
using System.Collections.Generic;
using System.Linq;

Profile[] arrProfile =
{
	new Profile(){Name="정우성", Height=186},
	new Profile(){Name="김태희", Height=158},
	new Profile(){Name="고현정", Height=172},
	new Profile(){Name="이문세", Height=178},
	new Profile(){Name="하하", Height=171}
};

// select 문을 통해 무명형식으로 반환 가능, 최종적으로 무명 형식 배열이됨
var profiles = from profile in arrProfile
			   where profile.Height < 175
			   orderby profile.Height
			   select new
			   {
				   Name = profile.Name,
				   InchHeight = profile.Height * 0.393
			   };

foreach (var profile in profiles)
	Console.WriteLine($"{profile.Name}, {profile.InchHeight}");

class Profile
{
	public string Name { get; set; }
	public int Height { get; set; }
}