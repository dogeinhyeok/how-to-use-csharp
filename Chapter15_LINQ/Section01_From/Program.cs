/* LINQ의 기본: IEnumerable<T>를 상속받은 형식에만 사용가능. */
using System.Linq;

int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

// from <범위변수> in <데이터 원본>: 데이터 원본으로부터 범위 변수를 뽑아낸 후 데이터 가공 및 추출.
// where <조건식>: 테이터의 필터 역할을 하는 연산자입니다.
// orderby <기준변수>: 데이터의 정렬을 수행하는 연산자입니다. (ascending: 오름차순, descending: 내림차순)
// select <출력변수>: 출력할 최종 결과를 추출해내는 것입니다.
var result = from n in numbers
			 where n % 2 == 0
			 orderby n descending
			 select n;

foreach (int n in result)
	Console.WriteLine($"짝수 : {n}");