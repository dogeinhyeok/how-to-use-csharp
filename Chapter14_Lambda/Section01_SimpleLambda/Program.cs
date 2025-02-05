/* 처음 만나는 람다식 */
Calculate calc = (a, b) => a + b;

Console.WriteLine($"{3} + {4} : {calc(3, 4)}");

delegate int Calculate(int a, int b);