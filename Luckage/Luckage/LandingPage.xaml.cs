using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Luckage
{
	public partial class LandingPage : ContentPage
	{
		public LandingPage()
		{
			InitializeComponent();
			time.Text = DateTime.Now.ToLocalTime().ToShortTimeString();
		}

		void backBtn_Click(object sender, EventArgs e)
		{
			App.Current.MainPage = new LoginPage();
		}

		void checkAirport_Click(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new airportMap());
		}

		void buySim_Click(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new SimCardPage());
		}

		void bagProblem_Click(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new BagProblemPage());
		}

		void deliveryBag_Click(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new DeliveryPage());
		}
	}
}
