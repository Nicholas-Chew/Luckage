using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Luckage
{
	public partial class SimCardPage : ContentPage
	{
		public SimCardPage()
		{
			InitializeComponent();
		}

		void backBtn_Click(object sender, EventArgs e)
		{
			Navigation.PopModalAsync();
		}

		void Singtel_Clicked(object sender, EventArgs e)
		{
			App.simName = "SingTel Prepaid SIM";
			App.simPicture = "simPage_SingTel.png";
			Navigation.PushModalAsync(new SimCardCheckOutPage());

		}


		void Starhub_Clicked(object sender, EventArgs e)
		{
			App.simName = "StarHub Prepaid SIM";
			App.simPicture = "simPage_StarHub.png";
			Navigation.PushModalAsync(new SimCardCheckOutPage());
		}

		void M1_Clicked(object sender, EventArgs e)
		{
			App.simName = "M1 Prepaid SIM";
			App.simPicture = "simPage_M1.png";
			Navigation.PushModalAsync(new SimCardCheckOutPage());

		}
	}
}
