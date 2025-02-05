/* with를 이용한 레코드 복사 */
RTransaction tr1 = new RTransaction { From = "Alice", To = "Bob", Amount = 100 };
RTransaction tr2 = tr1 with { To = "Charlie" }; // tr1의 모든 상태를 복사후, To 프로퍼티값만 변경
RTransaction tr3 = tr2 with { From = "Dave", Amount = 30 };

Console.WriteLine(tr1);
Console.WriteLine(tr2);
Console.WriteLine(tr3);

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