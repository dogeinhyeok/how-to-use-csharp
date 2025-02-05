/* 람다식을 이용한 식트리 */
using System.Linq.Expressions;

Expression<Func<int, int, int>> expression =
	(a, b) => 1 * 2 + (a - b);
Func<int, int, int> func = expression.Compile(); // 코드를 컴파일하여 데이터로 보관

// x = 7, y = 8
Console.WriteLine($"1*2+({7}-{8}) = {func(7, 8)}");