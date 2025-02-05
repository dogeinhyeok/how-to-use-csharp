/* 비트 논리 연산자 */
int a = 9;
int b = 10;

Console.WriteLine($"{a} & {b} : {a & b}"); // 9 & 10 : 8
Console.WriteLine($"{a} | {b} : {a | b}"); // 9 | 10 : 11
Console.WriteLine($"{a} ^ {b} : {a ^ b}"); // 9 ^ 10 : 3

int c = 255;
Console.WriteLine("~{0}(0x{0:X8}) : {1}(0x{1:X8})", c, -c); // ~255(0x000000FF) : -255(0xFFFFFF01)