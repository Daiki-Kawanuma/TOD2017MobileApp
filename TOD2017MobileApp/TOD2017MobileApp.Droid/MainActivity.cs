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
using TOD2017MobileApp.Models;

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
			LoadApplication(new App(new AndroidInitializer()));
		}

		private void Current_BatteryChanged(object sender, Plugin.Battery.Abstractions.BatteryChangedEventArgs e)
		{
			if (e.Status == BatteryStatus.Charging)
			{
				Console.WriteLine("********** Battery Event Charging **********");

				if ((Coordinate.TommyHome.LatitudeStart < App.CurrentPosition?.Latitude
					&& Coordinate.TommyHome.LatitudeEnd > App.CurrentPosition?.Latitude
					&& Coordinate.TommyHome.LongitudeStart < App.CurrentPosition?.Longitude
					 && Coordinate.TommyHome.LongitudeEnd > App.CurrentPosition?.Longitude)
					|| (Coordinate.Ynu.LatitudeStart < App.CurrentPosition?.Latitude
						 && Coordinate.Ynu.LatitudeEnd > App.CurrentPosition?.Latitude
						 && Coordinate.Ynu.LongitudeStart < App.CurrentPosition?.Longitude
						&& Coordinate.Ynu.LongitudeEnd > App.CurrentPosition?.Longitude))
				{
					Recreate();
				}
				else 
				{
					if (CrossGeolocator.Current.IsListening == false)
					{
						CrossGeolocator.Current.DesiredAccuracy = 1;
						CrossGeolocator.Current.StartListeningAsync(minTime: 1000, minDistance: 0, includeHeading: false);
					}
				}
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
			CrossBattery.Current.BatteryChanged -= Current_BatteryChanged;
			foreach (var disposable in App.EventList)
			{
				Console.WriteLine("Event dispose, " + disposable);
				disposable?.Dispose();
			}

			MapPageViewModel.Timer?.Stop();
			MapPageViewModel.Timer = null;
			ECGsPageViewModel.Timer?.Stop();
			ECGsPageViewModel.Timer = null;

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