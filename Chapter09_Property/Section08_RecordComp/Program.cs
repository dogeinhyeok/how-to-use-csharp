/* 레코드 객체 비교하기 */
CTransaction trA = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };
CTransaction trB = new CTransaction { From = "Alice", To = "Bob", Amount = 100 };

Console.WriteLine(trA);
Console.WriteLine(trB);
Console.WriteLine($"trA equals to trB : {trA.Equals(trB)}"); // class는 참조형식으로 비교해서 False

RTransaction tr1 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };
RTransaction tr2 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };

Console.WriteLine(tr1);
Console.WriteLine(tr2);
Console.WriteLine($"tr1 equals to tr2 : {tr1.Equals(tr2)}"); // record는 값형식으로 비교해서 True

class CTransaction
{
	public string From { get; init; }
	public string To { get; init; }
	public int Amount { get; init; }

	public override string ToString()
	{
		return $"{From,-10} -> {To,-10} : ${Amount}";
	}
}

record RTransaction
{
	public string From { get; init; }
	public string To { get; init; }
	public int Amount { get; init; }

	public override string ToString()
	{
		return $"{From,-10} -> {To,-10} : ${Amount}";
	}
}