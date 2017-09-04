using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using System.Threading;
using Plugin.Geolocator;


namespace Luckage
{
	public partial class DeliveryPage : ContentPage
	{

		Dictionary<string, string> deliveryOption = new Dictionary<string, string>
		{
			{ "Uber", "uber" }, { "DHL", "dhl" },

		};

		Geocoder geoCoder;

		public DeliveryPage()
		{
			InitializeComponent();
			geoCoder = new Geocoder();

			foreach (string deliveryOp in deliveryOption.Keys)
			{
				deliveryType.Items.Add(deliveryOp);
			}
			deliveryType.SelectedIndex = 0;

			getCurrentPos();

			//map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37, -122), Distance.FromMiles(1)));



		}

		async void getCurrentPos()
		{
			Position currentPos = new Position(1.2925232, 103.7742187);
			try
			{
				var locator = CrossGeolocator.Current;
				locator.DesiredAccuracy = 50;

				var position = await locator.GetPositionAsync(timeoutMilliseconds: 10000);

				map.MoveToRegion(MapSpan.FromCenterAndRadius(currentPos, Distance.FromMeters(300)));

				var pin = new Pin
				{
					Type = PinType.Place,
					Position = currentPos,
					Label = "Current Point",
					Address = "The Hangar by NUS Enterprise"
				};
				map.Pins.Add(pin);
			}
			catch (Exception ex)
			{
				//Debug.WriteLine("Unable to get location, may need to increase timeout: " + ex);
			}


		}


		async void geoCoding(String address)
		{
			bool done = false;
			var geoCode = await geoCoder.GetPositionsForAddressAsync(address);


			foreach (var position in geoCode)
			{
				if (!done)
				{
					map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(position.Latitude, position.Longitude), Distance.FromMeters(300)));
					done = true;

					var pin = new Pin
					{
						Type = PinType.Place,
						Position = position,
						Label = "Deliver Point",
						Address = address
					};
					map.Pins.Add(pin);
				}
			}

			payment.Text = "USD 10";


		}


		void Location_TextCompleted(object sender, EventArgs e)
		{
			geoCoding(((Editor)sender).Text);
		}

		void backBtn_Click(object sender, EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}
