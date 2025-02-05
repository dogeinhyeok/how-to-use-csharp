/* null 조건부 연산자 */
using System.Collections;

ArrayList a = null;
a?.Add("야구"); // a 객체가 null이 아니면 member 필드에 접근하게 해줌
a?.Add("축구");
Console.WriteLine($"Count : {a?.Count}");
Console.WriteLine($"{a?[0]}"); // a가 null이므로 출력되지 않음
Console.WriteLine($"{a?[1]}");

a = new ArrayList(); // a는 이제 더 이상 null이 아닙니다.
a?.Add("야구");
a?.Add("축구");
Console.WriteLine($"Count : {a?.Count}");
Console.WriteLine($"{a?[0]}");
Console.WriteLine($"{a?[1]}");