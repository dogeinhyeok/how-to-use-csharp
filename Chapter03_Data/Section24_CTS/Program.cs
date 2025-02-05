/* 공용 형식 시스템 */
System.Int32 a = 123;
int b = 456;

Console.WriteLine("a type:{0}, value:{1}", a.GetType().ToString(), a); // a type:System.Int32, value:123
Console.WriteLine("a type:{0}, value:{1}", b.GetType().ToString(), b); // a type:System.Int32, value:456

System.String c = "abc";
string d = "def";

Console.WriteLine("c type:{0}. value: {1}", c.GetType().ToString(), c); // c type:System.String. value: abc
Console.WriteLine("d type:{0}. value: {1}", d.GetType().ToString(), d); // d type:System.String. value: def