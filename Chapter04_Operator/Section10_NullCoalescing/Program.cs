/* null 병합 연산자 */
int? num = null;
Console.WriteLine($"{num ?? 0}"); // num이 null이므로 0이 출력됩니다.

num = 99;
Console.WriteLine($"{num ?? 0}"); // num이 null이 아니므로 99가 출력됩니다.

string str = null;
Console.WriteLine($"{str ?? "Default"}"); // str이 null이므로 "Default"가 출력됩니다.

str = "Specific";
Console.WriteLine($"{str ?? "Default"}"); // str이 null이 아니므로 "Specific"가 출력됩니다.