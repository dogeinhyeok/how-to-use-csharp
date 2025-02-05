/* 레코드 선언하기 */
RTransaction tr1 = new RTransaction
{
	From = "Alice",
	To = "Bob",
	Amount = 100
};

RTransaction tr2 = new RTransaction
{
	From = "Alice",
	To = "Charlie",
	Amount = 100
};

Console.WriteLine(tr1);
Console.WriteLine(tr2);
// tr1.From = "A"; // 불변성: 레코드는 기본적으로 불변입니다

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