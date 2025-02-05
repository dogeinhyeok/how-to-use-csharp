/* 오버플로우 */
uint a = uint.MaxValue;

Console.WriteLine(a); // 4294967295

a = a + 1;

Console.WriteLine(a); // 0