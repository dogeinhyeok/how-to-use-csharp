/* 메소드의 결과를 참조로 반환하기 */
Product carrot = new Product();
ref int ref_local_price = ref carrot.GetPrice(); // 참조
int normal_local_price = carrot.GetPrice();

carrot.PrintPrice(); // 100
Console.WriteLine($"Ref Local Price: {ref_local_price}"); // 100
Console.WriteLine($"Normal Local Price: {normal_local_price}"); // 100

ref_local_price = 200; // 실제 클래스 매개변수도 같이 바뀜

carrot.PrintPrice(); // 200
Console.WriteLine($"Ref Local Price: {ref_local_price}"); // 200
Console.WriteLine($"Normal Local Price: {normal_local_price}"); // 100

class Product
{
	private int price = 100;

	public ref int GetPrice()
	{
		return ref price;
	}

	public void PrintPrice()
	{
		Console.WriteLine($"Price :{price}");
	}
}
