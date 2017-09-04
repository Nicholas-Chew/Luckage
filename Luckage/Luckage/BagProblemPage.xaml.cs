using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Luckage
{
	public partial class BagProblemPage : ContentPage
	{
		public BagProblemPage()
		{
			InitializeComponent();
			time.Text = DateTime.Now.ToLocalTime().ToShortTimeString();
		}

		void backBtn_Click(object sender, EventArgs e)
		{
			Navigation.PopModalAsync();
		}

		async void sendBtn_Clicked(object sender, EventArgs e)
		{
			var answer = await DisplayAlert("SIA", "Message Send. We will get back to you soon.", "OK", "Cancel");

			Navigation.PopModalAsync();
		}
	}
}
