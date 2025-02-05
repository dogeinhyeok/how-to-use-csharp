/* 읽기 전용 구조체 */
RGBColor Red = new RGBColor(255, 0, 0);
Red.G = 100; // 읽기 전용이므로 컴파일 에러

readonly struct RGBColor
{
	public readonly byte R;
	public readonly byte G;
	public readonly byte B;

	public RGBColor(byte r, byte g, byte b)
	{
		R = r;
		G = g;
		B = b;
	}
}