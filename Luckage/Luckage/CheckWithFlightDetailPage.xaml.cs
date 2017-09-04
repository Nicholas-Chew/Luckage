using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Luckage
{
	public partial class CheckWithFlightDetailPage : ContentPage
	{
		Dictionary<string, string> arrDep = new Dictionary<string, string>
		{
			{ "Arrival", "A" }, { "Departure", "D" },

		};

		Dictionary<string, string> airPortCode = new Dictionary<string, string>
		{
			{ "Singapore Changi", "chi" }, { "Malaysia KL", "mkl" },

		};

		Dictionary<string, string> airLineCode = new Dictionary<string, string>
		{
			{ "Singapore Airline", "SIA" }

		};

		public CheckWithFlightDetailPage()
		{
			InitializeComponent();

			foreach (string arrDep in arrDep.Keys)
			{
				arr_dep_indicator.Items.Add(arrDep);
			}

			arr_dep_indicator.SelectedIndex = 0;

			foreach (string airPort in airPortCode.Keys)
			{
				airportCode.Items.Add(airPort);
			}

			airportCode.SelectedIndex = 0;

			foreach (string airLine in airLineCode.Keys)
			{
				airline_code.Items.Add(airLine);
			}
			airline_code.SelectedIndex = 0;

		}

		void submit_Click(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new LandingPage());
		}

	}
}
