using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace GeoTest.Droid
{
    [Activity(Theme = "@style/Theme.Splash", //Indicates the theme to use for this activity
             MainLauncher = true, //Set it as boot activity
             ScreenOrientation = Android.Content.PM.ScreenOrientation.Portrait, // Start in portrait mode?
             ConfigurationChanges = Android.Content.PM.ConfigChanges.Orientation & Android.Content.PM.ConfigChanges.ScreenSize, // Indicate that we will handle orientation and screensize changes (by ignoring them)
             NoHistory = true)] //Doesn't place it in back stack
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            this.StartActivity(typeof(MainActivity));
            this.Dispose();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            Plugin.Permissions.PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}