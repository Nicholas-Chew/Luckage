using Xamarin.Forms;

namespace Luckage
{
	public partial class App : Application
	{
		public static string simName;
		public static string simPicture;

		public App()
		{
			InitializeComponent();

			MainPage = new LoginPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
