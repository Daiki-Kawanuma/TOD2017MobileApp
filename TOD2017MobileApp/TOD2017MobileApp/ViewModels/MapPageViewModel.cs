using System;
using System.Linq;
using Prism.Mvvm;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Prism.Commands;
using Prism.Navigation;
using Prism.Services;
using Reactive.Bindings;
using TOD2017MobileApp.Models;
using TOD2017MobileApp.Views;

namespace TOD2017MobileApp.ViewModels
{
    public class MapPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;
        private readonly IPageDialogService _pageDialogService;
        public ReactiveProperty<string> Location { get; set; }
        public DelegateCommand NavigateToInsertionPageCommand { get; set; }
        public DelegateCommand NavigateToDemoPageCommand { get; set; }

        public MapPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
            Location = new ReactiveProperty<string>();
            NavigateToInsertionPageCommand = new DelegateCommand(() =>
            {
                _navigationService.NavigateAsync(nameof(DataInsertionPage));
            });
            NavigateToDemoPageCommand = new DelegateCommand(() =>
            {
                _navigationService.NavigateAsync(nameof(ECGsDemoPage));
            });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            CrossGeolocator.Current.PositionChanged -= OnPositionChanged;
        }

        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Location);
            if (status != PermissionStatus.Granted)
            {
                if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Location))
                {
                    await _pageDialogService.DisplayAlertAsync("Need location", "Gunna need that location", "OK");
                    
                }
                await CrossPermissions.Current.RequestPermissionsAsync(Permission.Location);
            }

            CrossGeolocator.Current.PositionChanged += OnPositionChanged;

            if (CrossGeolocator.Current.IsListening == false)
            {
                CrossGeolocator.Current.DesiredAccuracy = 1;
                await CrossGeolocator.Current.StartListeningAsync(minTime: 1000, minDistance: 0, includeHeading: false);
            }
        }

        private void OnPositionChanged(object sender, PositionEventArgs e)
        {
            Location.Value = $"{e.Position.Latitude}, {e.Position.Longitude}, {e.Position.Timestamp.LocalDateTime}";

            var semanticLink = SemanticLink.TargetSemanticLinks
            .FirstOrDefault(v => e.Position.Latitude > v.MinLatitude
            && e.Position.Latitude < v.MaxLatitude
            && e.Position.Longitude > v.MinLongitude
            && e.Position.Longitude < v.MaxLongitude);

            //var semanticLink = SemanticLink.TargetSemanticLinks.FirstOrDefault(v => v.SemanticLinkId == 196);

            if (semanticLink != null)
            {
                var navigationParameters = new NavigationParameters
                {
                    {ECGsPageViewModel.ParamSemanticLink, semanticLink}
                };
                _navigationService.NavigateAsync($"/{nameof(ECGsPage)}", navigationParameters);
            }
        }
    }
}
