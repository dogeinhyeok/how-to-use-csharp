/* C# 코드로 WinForm 윈도우 만들기 */
// GUI 애플리케이션에서는 최상위 구문을 사용할 수 없습니다.
class MainApp : System.Windows.Forms.Form
{
	static void Main(string[] args)
	{
		System.Windows.Forms.Application.Run(new MainApp());
	}
}