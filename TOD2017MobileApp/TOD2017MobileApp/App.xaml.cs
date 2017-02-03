using System;
using System.Collections.Generic;
using Plugin.Geolocator.Abstractions;
using Prism.Unity;
using TOD2017MobileApp.Views;
using Xamarin.Forms;

namespace TOD2017MobileApp
{
    public partial class App : PrismApplication
    {
        public static string AppStatus;
		public static IList<IDisposable> EventList = new List<IDisposable>();
		public static Position CurrentPosition;

        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync(nameof(EnergyStackPage));
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<ECGsPage>();
            Container.RegisterTypeForNavigation<MapPage>();
            Container.RegisterTypeForNavigation<ResultPage>();
            Container.RegisterTypeForNavigation<DataInsertionPage>();
            Container.RegisterTypeForNavigation<ECGsDemoPage>();
			Container.RegisterTypeForNavigation<EnergyStackPage>();
        }
    }
}
