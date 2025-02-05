/* 시프트 연산자 */
Console.WriteLine("Testing <<...");

int a = 1;
Console.WriteLine("a      : {0:D5} (0x{0:X8})", a);         // 0x00000001
Console.WriteLine("a << 1 : {0:D5} (0x{0:X8})", a << 1);    // 0x00000002
Console.WriteLine("a << 2 : {0:D5} (0x{0:X8})", a << 2);    // 0x00000004
Console.WriteLine("a << 5 : {0:D5} (0x{0:X8})", a << 5);    // 0x00000020

Console.WriteLine("\nTesting >>...");

int b = 255;
Console.WriteLine("b      : {0:D5} (0x{0:X8})", b);         // 0x000000FF
Console.WriteLine("b >> 1 : {0:D5} (0x{0:X8})", b >> 1);    // 0x0000007F
Console.WriteLine("b >> 2 : {0:D5} (0x{0:X8})", b >> 2);    // 0x0000003F
Console.WriteLine("b >> 5 : {0:D5} (0x{0:X8})", b >> 5);    // 0x00000007

Console.WriteLine("\nTesting >> 2...");

int c = -255;
Console.WriteLine("c      : {0:D5} (0x{0:X8})", c);         // 0xFFFFFF01
Console.WriteLine("c >> 1 : {0:D5} (0x{0:X8})", c >> 1);    // 0xFFFFFF80
Console.WriteLine("c >> 2 : {0:D5} (0x{0:X8})", c >> 2);    // 0xFFFFFFC0
Console.WriteLine("c >> 5 : {0:D5} (0x{0:X8})", c >> 5);    // 0xFFFFFFF8