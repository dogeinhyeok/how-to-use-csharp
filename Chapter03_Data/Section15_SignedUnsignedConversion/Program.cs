/* 부호 있는 정수 형식과 부호 없는 정수 형식 사이의 변환 */
int a = 500;
Console.WriteLine(a);

uint b = (uint)a;
Console.WriteLine(b);

int x = -30;
Console.WriteLine(x);

uint y = (uint)x; // 언더플로우 발생!
Console.WriteLine(y); // 4294967266