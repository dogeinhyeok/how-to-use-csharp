/* 형식 매개변수<T> 제약시키기 */
// 구조체 배열 생성
StructArray<int> a = new StructArray<int>(3);
a.Array[0] = 0;
a.Array[1] = 1;
a.Array[2] = 2;
for (int i = 0; i < 3; i++)
	Console.WriteLine($"{a.Array[i]}");
Console.WriteLine();

// 구조체 배열의 참조 배열 생성
RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
b.Array[0] = new StructArray<double>(5);
b.Array[1] = new StructArray<double>(10);
b.Array[2] = new StructArray<double>(1005);
for (int i = 0; i < 3; i++)
	Console.WriteLine($"{b.Array[i].Array.Length}");
Console.WriteLine();

// Base 배열 생성
BaseArray<Base> c = new BaseArray<Base>(3);
c.Array[0] = new Base();
c.Array[1] = new Derived();
c.Array[2] = CreateInstance<Base>();
for (int i = 0; i < 3; i++)
	Console.WriteLine($"{c.Array[i]}");
Console.WriteLine();

// Derived 배열 생성
BaseArray<Derived> d = new BaseArray<Derived>(3);
d.Array[0] = new Derived(); // Base 형식은 여기에 할당 할 수 없다.
d.Array[1] = CreateInstance<Derived>();
d.Array[2] = CreateInstance<Derived>();
for (int i = 0; i < 3; i++)
	Console.WriteLine($"{d.Array[i]}");
Console.WriteLine();

// 배열 복사
BaseArray<Derived> e = new BaseArray<Derived>(3);
e.CopyArray<Derived>(d.Array);
for (int i = 0; i < 3; i++)
	Console.WriteLine($"{e.Array[i]}");
Console.WriteLine();

// T는 반드시 매개변수가 없는 생성자가 있어야합니다
static T CreateInstance<T>() where T : new()
{
	return new T();
}

// T는 값 형식이어야 합니다
class StructArray<T> where T : struct
{
	public T[] Array { get; set; }
	public StructArray(int size)
	{
		Array = new T[size];
	}
}

// T는 참조 형식이어야 합니다
class RefArray<T> where T : class
{
	public T[] Array { get; set; }
	public RefArray(int size)
	{
		Array = new T[size];
	}
}

class Base { }

class Derived : Base { }

// U는 Base로부터 상속받은 클래스여야 합니다
class BaseArray<U> where U : Base
{
	public U[] Array { get; set; }
	public BaseArray(int size)
	{
		Array = new U[size];
	}

	// T는 U로부터 상속받은 클래스여야 합니다
	public void CopyArray<T>(T[] Target) where T : U
	{
		Target.CopyTo(Array, 0);
	}
}