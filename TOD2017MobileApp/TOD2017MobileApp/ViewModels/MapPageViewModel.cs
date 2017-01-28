using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using TOD2017MobileApp.Test;
using TOD2017MobileApp.Views;
using Xamarin.Forms;
using DependencyService = Xamarin.Forms.DependencyService;

namespace TOD2017MobileApp.ViewModels
{
    public class MapPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;
        private readonly IPageDialogService _pageDialogService;
        private bool _didFinishedNavigation;
        private ReactiveTimer _timer;
        public ReactiveProperty<string> Location { get; set; }
        public DelegateCommand NavigateToInsertionPageCommand { get; set; }
        public DelegateCommand NavigateToDemoPageCommand { get; set; }

        public MapPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            _navigationService = navigationService;
            _pageDialogService = pageDialogService;
            _didFinishedNavigation = false;
            Location = new ReactiveProperty<string>();
            NavigateToInsertionPageCommand =
                new DelegateCommand(() => { _navigationService.NavigateAsync(nameof(DataInsertionPage)); });
            NavigateToDemoPageCommand =
                new DelegateCommand(() => { _navigationService.NavigateAsync(nameof(ECGsDemoPage)); });
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            CrossGeolocator.Current.PositionChanged -= OnPositionChanged;
            //_timer.Stop();
            //_timer = null;
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

            /*** テストコード ***/
            /*int i = 0;
            var positions = TestPosition.TestPositions;
            _timer = new ReactiveTimer(TimeSpan.FromMilliseconds(10));
            _timer.Subscribe(x =>
            {
                OnPositionChanged(null, new PositionEventArgs(positions[i]));
                i++;
            });
            _timer.Start();*/
            /*** テストコード ***/
        }

        private void OnPositionChanged(object sender, PositionEventArgs e)
        {
            Device.BeginInvokeOnMainThread(async() =>
            {
                if(_didFinishedNavigation)
                    return;

                Location.Value = $"{e.Position.Latitude}, {e.Position.Longitude}, {e.Position.Timestamp.LocalDateTime}";

                if (Coordinate.TommyHome.LatitudeStart < e.Position.Latitude
                    && Coordinate.TommyHome.LatitudeEnd > e.Position.Latitude
                    && Coordinate.TommyHome.LongitudeStart < e.Position.Longitude
                    && Coordinate.TommyHome.LongitudeEnd > e.Position.Longitude)
                {
                    SemanticLink.TargetSemanticLinks = SemanticLink.OutwardSemanticLinks;
                }
                else if (Coordinate.Ynu.LatitudeStart < e.Position.Latitude
                         && Coordinate.Ynu.LatitudeEnd > e.Position.Latitude
                         && Coordinate.Ynu.LongitudeStart < e.Position.Longitude
                         && Coordinate.Ynu.LongitudeEnd > e.Position.Longitude)
                {
                    SemanticLink.TargetSemanticLinks = SemanticLink.HomewardSemanticLinks;
                }

                if (SemanticLink.TargetSemanticLinks == null)
                {
                    await _pageDialogService.DisplayActionSheetAsync("位置検知エラー", "出発地点を特定できませんでした", "OK");
                    return;
                }

                var semanticLink = SemanticLink.TargetSemanticLinks
                    .FirstOrDefault(v => e.Position.Latitude > v.MinLatitude
                                         && e.Position.Latitude < v.MaxLatitude
                                         && e.Position.Longitude > v.MinLongitude
                                         && e.Position.Longitude < v.MaxLongitude);

                //semanticLink = SemanticLink.TargetSemanticLinks.FirstOrDefault(v => v.SemanticLinkId == 196);

                if (semanticLink != null)
                {
                    _didFinishedNavigation = true;
                    
                    var navigationParameters = new NavigationParameters
                    {
                        {ECGsPageViewModel.ParamSemanticLink, semanticLink}
                    };
                    await _navigationService.NavigateAsync("/ECGsPage", navigationParameters);
                }
            });
        }
    }
}