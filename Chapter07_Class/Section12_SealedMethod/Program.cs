/* 오버라이딩 봉인하기 */
static void Main(string[] args)
{

}

class Base
{
	public virtual void SealMe()
	{
	}
}

class Derived : Base
{
	public sealed override void SealMe()
	{
	}
}

class WantToOverride : Derived
{
	public override void SealMe()
	{
		// 오버라이드 불가
	}
}