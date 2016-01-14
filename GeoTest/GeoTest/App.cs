//using Geolocator.Plugin;
//using Geolocator.Plugin.Abstractions;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace GeoTest
{
    public class App : Application
    {
        public Label lab;

        public App()
        {
            lab = new Label
            {
                XAlign = TextAlignment.Center,
                Text = "Getting GPS position..."
            };

            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
						lab
                    }
                }
            };

            GetLoc();
        }

        private async void GetLoc()
        {
            var loc = CrossGeolocator.Current;
            var pos = await loc.GetPositionAsync();

            lab.Text = string.Format("Location: lat {0}, lng {1}", pos.Latitude, pos.Longitude);
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
