/* Func 대리자: 결과를 반환하는 무명 메소드 */
Func<int> func1 = () => 10;
Console.WriteLine($"func1() : {func1()}"); // 출력: 10

Func<int, int> func2 = (x) => x * 2;
Console.WriteLine($"func2(4) : {func2(4)}"); // 출력: 8

Func<double, double, double> func3 = (x, y) => x / y;
Console.WriteLine($"func3(22, 7) : {func3(22, 7)}"); // 출력: 3.1428...