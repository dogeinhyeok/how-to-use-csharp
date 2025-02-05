/* Application 클래스 */
using System.Windows.Forms;

namespace UsingApplication
{
	class MainApp : Form
	{
		static void Main(string[] args)
		{
			MainApp form = new MainApp();

			// 이 코드는 윈도우를 클릭하면 Application.Exit()를 호출합니다
			form.Click += new EventHandler((sender, eventArgs) =>
			{
				Console.WriteLine("Closing Window...");
				Application.Exit();
			});

			Console.WriteLine("Starting Window Application...");
			Application.Run(form);

			Console.WriteLine("Exiting Window Application...");
		}
	}
}