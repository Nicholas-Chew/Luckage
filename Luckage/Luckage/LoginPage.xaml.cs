using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Luckage
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage()
		{
			InitializeComponent();

		}


		void scanBordingPass_Click(object sender, EventArgs e)
		{

		}


		void checkWithFlight_Click(object sender, EventArgs e)
		{
			App.Current.MainPage = new CheckWithFlightDetailPage();
			//Navigation.PushModalAsync(new LandingPage());

		}

	}
}
