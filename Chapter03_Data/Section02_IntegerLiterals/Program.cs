/* 2진수, 10진수, 16진수 리터럴 */
byte a = 240; // 10진수 리터럴
Console.WriteLine($"a={a}"); // 240

byte b = 0b1111_0000; // 2진수 리터럴
Console.WriteLine($"b={b}"); // 240

byte c = 0XF0; // 16진수 리터럴
Console.WriteLine($"c={c}"); // 240

uint d = 0x1234_abcd; // 16진수 리터럴
Console.WriteLine($"d={d}"); // 305441741