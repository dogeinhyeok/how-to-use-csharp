/* 문자열 보간 */
string name = "김튼튼";
int age = 23;
Console.WriteLine($"{name,-10}, {age:D3}"); // $"{<변수명>,<길이>:<서식>}"

name = "박날씬";
age = 30;
Console.WriteLine($"{name}, {age,-10:D3}");