/* 크기가 서로 다른 부동 소수점 형식 사이의 변환 */
float a = 69.6875f;
Console.WriteLine("a : {0}", a); // a : 69.6875

double b = (double)a; // float와 double를 사이에서 형식 변환시 손상
Console.WriteLine("b : {0}", b); // b : 69.6875
Console.WriteLine("69.6875 == b : {0}", 69.6875 == b); // 69.6875 == b : True

float x = 0.1f;
Console.WriteLine("x : {0}", x); // x : 0.1

double y = (double)x;
Console.WriteLine("y : {0}", y); // y : 0.10000000149011612

Console.WriteLine("0.1 == y : {0}", 0.1 == y); // 0.1 == y : False