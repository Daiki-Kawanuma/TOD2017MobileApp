using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Java.IO;
using Prism.Unity;
using Microsoft.Practices.Unity;
using PCLStorage;
using Plugin.Battery;
using Plugin.Geolocator;
using TOD2017MobileApp.ViewModels;
using BatteryStatus = Plugin.Battery.Abstractions.BatteryStatus;
using Console = System.Console;
using Environment = Android.OS.Environment;
using File = Java.IO.File;

namespace TOD2017MobileApp.Droid
{
    [Activity(Label = "TOD2017MobileApp", Icon = "@drawable/icon", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        ScreenOrientation = ScreenOrientation.Landscape)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        private static readonly string RootFolderPath = "/sdcard/Download";

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.tabs;
            ToolbarResource = Resource.Layout.toolbar;

            base.OnCreate(bundle);
            Window.AddFlags(WindowManagerFlags.KeepScreenOn | WindowManagerFlags.TurnScreenOn);
            Window.Attributes.ScreenBrightness = 1.0f;
            global::Xamarin.Forms.Forms.Init(this, bundle);

            AppDomain.CurrentDomain.UnhandledException += (s, e) =>
            {
                var exception = e.ExceptionObject as Exception;

                var filePath = RootFolderPath + $"/Exception_{DateTime.Now.ToString("yyyyMMdd-HHmmss")}.txt";

                var fos = new FileStream(filePath, FileMode.CreateNew);
                var osw = new OutputStreamWriter(fos, "UTF-8");
                var bw = new BufferedWriter(osw);
                bw.Write(exception.Message + "\n" + exception.StackTrace);
                bw.Flush();
                bw.Close();
            };

            TaskScheduler.UnobservedTaskException += (s, e) =>
            {
                var filePath = RootFolderPath + $"/Exception_{DateTime.Now.ToString("yyyyMMdd-HHmmss")}.txt";

                var fos = new FileStream(filePath, FileMode.CreateNew);
                var osw = new OutputStreamWriter(fos, "UTF-8");
                var bw = new BufferedWriter(osw);
                bw.Write(e.Exception.Message + "\n" + e.Exception.StackTrace);
                bw.Flush();
                bw.Close();
            };

            AndroidEnvironment.UnhandledExceptionRaiser += (s, e) =>
            {
                var filePath = RootFolderPath + $"/Exception_{DateTime.Now.ToString("yyyyMMdd-HHmmss")}.txt";

                var fos = new FileStream(filePath, FileMode.CreateNew);
                var osw = new OutputStreamWriter(fos, "UTF-8");
                var bw = new BufferedWriter(osw);
                bw.Write(e.Exception.Message + "\n" + e.Exception.StackTrace);
                bw.Flush();
                bw.Close();
            };

            CrossBattery.Current.BatteryChanged += Current_BatteryChanged;

            // Xamarin.Forms.Forms.Init()の後にOxyPlot.Xamarin.Forms.Platform.Android.PlotViewRenderer.Init()を呼ぶ
            OxyPlot.Xamarin.Forms.Platform.Android.PlotViewRenderer.Init();
            Xamarin.FormsGoogleMaps.Init(this, bundle);
            LoadApplication(new App(new AndroidInitializer()));
        }

        private void Current_BatteryChanged(object sender, Plugin.Battery.Abstractions.BatteryChangedEventArgs e)
        {
            if (e.Status == BatteryStatus.Charging)
            {                
                //MapPageViewModel.Timer?.Stop();
                //MapPageViewModel.Timer = null;
                Recreate();                
            }
            else
            {
                if (CrossGeolocator.Current.IsListening)
                    CrossGeolocator.Current.StopListeningAsync();
                Window.ClearFlags(WindowManagerFlags.KeepScreenOn | WindowManagerFlags.TurnScreenOn);
            }
        }

        protected override void OnDestroy()
        {
            CrossGeolocator.Current.StopListeningAsync();
            base.OnDestroy();
        }
    }

    public class AndroidInitializer : IPlatformInitializer
    {
        public void RegisterTypes(IUnityContainer container)
        {
        }
    }
}