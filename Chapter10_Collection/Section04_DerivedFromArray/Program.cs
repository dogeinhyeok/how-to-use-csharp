/* 알아두면 삶이 윤택해지는 System.Array */
int[] array = new int[] { 10, 30, 20, 7, 1 };
Console.WriteLine($"Type Of array : {array.GetType()}");
Console.WriteLine($"Base type Of array : {array.GetType().BaseType}"); // System.Array 형식에서 파생됨