using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Luckage
{
	public partial class airportMap : ContentPage
	{
		public airportMap()
		{
			InitializeComponent();
			Browser.Source = "http://www.changiairport.com/en/maps.html";
		}

		void backBtn_Click(object sender, EventArgs e)
		{
			Navigation.PopModalAsync();
		}

		void webOnNavigating(object sender, WebNavigatingEventArgs e)
		{
			//LoadingLabel.IsVisible = true;
		}

		void webOnEndNavigating(object sender, WebNavigatedEventArgs e)
		{
			LoadingLabel.IsVisible = false;
		}
	}
}
