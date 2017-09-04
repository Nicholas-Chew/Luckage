using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Luckage
{
	public partial class SimCardCheckOutPage : ContentPage
	{
		public SimCardCheckOutPage()
		{
			InitializeComponent();

			simImg.Source = ImageSource.FromFile(App.simPicture);
			localSim.Text = App.simName;
		}

		void backBtn_Click(object sender, EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}
