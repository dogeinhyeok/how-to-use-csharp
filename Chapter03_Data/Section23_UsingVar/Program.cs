/* var: 데이터 형식을 알아서 파악하는 똑똑한 C# 컴파일러 */
var a = 20;
Console.WriteLine("Type: {0}, Value: {1}", a.GetType(), a); // Type: System.Int32, Value: 20

var b = 3.1414213;
Console.WriteLine("Type: {0}, Value: {1}", b.GetType(), b); // Type: System.Double, Value: 3.1414213

var c = "Hello, World!";
Console.WriteLine("Type: {0}, Value: {1}", c.GetType(), c); // Type: System.String, Value: Hello, World!

var d = new int[] { 10, 20, 30 };
Console.Write("Type: {0}, Value: ", d.GetType());
foreach (var e in d)
	Console.Write("{0} ", e);

Console.WriteLine(); // Type: System.Int32[], Value: 10 20 30