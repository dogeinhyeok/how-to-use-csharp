/* 추상 클래스의 프로퍼티 */
Product product_1 = new MyProduct()
{ ProductDate = new DateTime(2010, 1, 10) };

Console.WriteLine("Product:{0}, Product Date :{1}",
	product_1.SerialID,
	product_1.ProductDate);

Product product_2 = new MyProduct()
{ ProductDate = new DateTime(2010, 2, 3) };

Console.WriteLine("Product:{0}, Product Date :{1}",
	product_2.SerialID,
	product_2.ProductDate);


abstract class Product
{
	private static int serial = 0;
	public string SerialID
	{
		get { return String.Format("{0:d5}", serial++); }
	}

	// 추상 클래스도 프로퍼티를 가질 수 있습니다.
	abstract public DateTime ProductDate
	{
		get;
		set;
	}
}

class MyProduct : Product
{
	// 반드시 구현해야합니다.
	public override DateTime ProductDate
	{
		get;
		set;
	}
}