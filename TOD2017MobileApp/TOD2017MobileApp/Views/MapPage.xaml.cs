using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;

namespace TOD2017MobileApp.Views
{
    public partial class MapPage : ContentPage
    {
        public MapPage()
        {
            InitializeComponent();
            
        }

        private void OnPositionChanged(object sender, PositionEventArgs e)
        {
            MyMap.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Xamarin.Forms.GoogleMaps.Position(e.Position.Latitude, e.Position.Longitude),
                    Distance.FromMiles(1)), 
                true);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CrossGeolocator.Current.PositionChanged += OnPositionChanged;
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            CrossGeolocator.Current.PositionChanged -= OnPositionChanged;
        }
    }
}
