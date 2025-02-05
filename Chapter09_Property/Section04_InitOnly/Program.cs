/* 초기화 전용 자동 구현 프로퍼티 */
Transaction tr1 = new Transaction { From = "Alice", To = "Bob", Amount = 100 };
Transaction tr2 = new Transaction { From = "Bob", To = "Charlie", Amount = 50 };
Transaction tr3 = new Transaction { From = "Charlie", To = "Alice", Amount = 50 };

Console.WriteLine(tr1);
Console.WriteLine(tr2);
Console.WriteLine(tr3);

class Transaction
{
	// init 접근자 사용시 객체를 초기화할 때만 프로퍼티 변경 가능
	public string From { get; init; }
	public string To { get; init; }
	public int Amount { get; init; }

	public override string ToString()
	{
		return $"{From,-10} -> {To,-10} : ${Amount}";
	}
}