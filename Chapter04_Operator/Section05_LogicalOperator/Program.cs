/* 논리 연산자 */
Console.WriteLine("Testing && ...");
Console.WriteLine($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}");    // True
Console.WriteLine($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}");    // False
Console.WriteLine($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}");  // False
Console.WriteLine($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}");  // False

Console.WriteLine("\nTesting || ...");
Console.WriteLine($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}");    // True
Console.WriteLine($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}");    // True
Console.WriteLine($"1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}");  // False
Console.WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}");  // True

Console.WriteLine("\nTesting ! ...");
Console.WriteLine($"!True {!true}");    // False
Console.WriteLine($"!False {!false}");  // True
