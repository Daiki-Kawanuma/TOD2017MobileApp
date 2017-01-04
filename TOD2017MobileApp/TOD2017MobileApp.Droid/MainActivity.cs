using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Prism.Unity;
using Microsoft.Practices.Unity;
using Plugin.Geolocator;

namespace TOD2017MobileApp.Droid
{
    [Activity(Label = "TOD2017MobileApp", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.tabs;
            ToolbarResource = Resource.Layout.toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            // Xamarin.Forms.Forms.Init()の後にOxyPlot.Xamarin.Forms.Platform.Android.PlotViewRenderer.Init()を呼ぶ
            OxyPlot.Xamarin.Forms.Platform.Android.PlotViewRenderer.Init();
            Xamarin.FormsGoogleMaps.Init(this, bundle);
            LoadApplication(new App(new AndroidInitializer()));
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            CrossGeolocator.Current.StopListeningAsync();
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {

        }
    }
}

