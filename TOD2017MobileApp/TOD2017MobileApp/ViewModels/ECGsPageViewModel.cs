using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using Prism.Navigation;
using Reactive.Bindings;
using TOD2017MobileApp.Models;
using TOD2017MobileApp.Views;

namespace TOD2017MobileApp.ViewModels
{
    public class ECGsPageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;
        public static readonly string ParamSemanticLink = "semantic_link";
        public static readonly string ParamCalculator = "calculator";
        private SemanticLink _semanticLink;
        private ECGModel _ecgModel;
        private double _maximum;
        private ECOLOGCalculator _ecologCalculator;

        public ReactiveProperty<PlotModel> PlotModelConvertLoss { get; set; }
        public ReactiveProperty<PlotModel> PlotModelAirResistance { get; set; }
        public ReactiveProperty<PlotModel> PlotModelRollingResistance { get; set; }
        public ReactiveProperty<PlotModel> PlotModelRegeneLoss { get; set; }
        public ReactiveProperty<string> AtentionText { get; set; }

        public ECGsPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            PlotModelConvertLoss = new ReactiveProperty<PlotModel>();
            PlotModelAirResistance = new ReactiveProperty<PlotModel>();
            PlotModelRollingResistance = new ReactiveProperty<PlotModel>();
            PlotModelRegeneLoss = new ReactiveProperty<PlotModel>();
            AtentionText = new ReactiveProperty<string>();
        }

        private PlotModel CreatePlotModel(string propertyName)
        {
            string title = null;
            switch (propertyName)
            {
                case "ConvertLoss":
                    title = "Convert loss";
                    break;
                case "AirResistance":
                    title = "Air resistance";
                    break;
                case "RollingResistance":
                    title = "Rolling resistance";
                    break;
                case "RegeneLoss":
                    title = "Regene loss";
                    break;
            }

            var model = new PlotModel
            {
                Subtitle = title,
                PlotMargins = new OxyThickness(double.NaN, double.NaN, 80, double.NaN)
            };

            var colorAxis = new LinearColorAxis
            {
                HighColor = OxyColors.Gray,
                LowColor = OxyColors.Black,
                Position = AxisPosition.Right,
                MajorStep = 0.02,
                Minimum = 0,
                Maximum = _maximum,
                Unit = "kWh",
                AxisTitleDistance = 0
            };
            model.Axes.Add(colorAxis);

            var xAxis = new LinearAxis
            {
                Title = "Transit time",
                Unit = "s",
                Position = AxisPosition.Bottom
            };
            model.Axes.Add(xAxis);
            var yAxis = new LinearAxis
            {
                Title = "Lost energy",
                Unit = "kWh"
            };
            model.Axes.Add(yAxis);

            var scatterSeries = new ScatterSeries();

            foreach (var datum in _ecgModel.GraphData)
            {
                scatterSeries.Points.Add(new ScatterPoint(datum.TransitTime, datum.LostEnergy)
                {
                    Value = (float)typeof(GraphDatum).GetRuntimeProperty(propertyName).GetValue(datum)
                });
            }

            model.Series.Add(scatterSeries);

            return model;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            CrossGeolocator.Current.PositionChanged -= OnPositionChanged;
        }

        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey(ParamCalculator))
            {
                _ecologCalculator = parameters[ParamCalculator] as ECOLOGCalculator;
            }
            else
            {
                _ecologCalculator = new ECOLOGCalculator();
                _ecologCalculator.Init();
            }

            _ecologCalculator = new ECOLOGCalculator();
            _ecologCalculator.Init();

            _semanticLink = parameters[ParamSemanticLink] as SemanticLink;
            _ecgModel = ECGModel.GetECGModel(_semanticLink);

            _maximum = new double[]
            {
                _ecgModel.GraphData.Max(v => v.ConvertLoss),
                _ecgModel.GraphData.Max(v => v.AirResistance),
                _ecgModel.GraphData.Max(v => v.RollingResistance),
                _ecgModel.GraphData.Max(v => v.RegeneLoss)
            }.Max();

            PlotModelConvertLoss.Value = CreatePlotModel("ConvertLoss");
            PlotModelAirResistance.Value = CreatePlotModel("AirResistance");
            PlotModelRollingResistance.Value = CreatePlotModel("RollingResistance");
            PlotModelRegeneLoss.Value = CreatePlotModel("RegeneLoss");

            AtentionText.Value = _ecgModel.AtentionText;

            CrossGeolocator.Current.PositionChanged += OnPositionChanged;

            if (CrossGeolocator.Current.IsListening == false)
            {
                CrossGeolocator.Current.DesiredAccuracy = 1;
                await CrossGeolocator.Current.StartListeningAsync(minTime: 1000, minDistance: 0, includeHeading: false);
            }
        }

        private void OnPositionChanged(object sender, PositionEventArgs e)
        {
            if (e.Position.Latitude < _semanticLink.MinLatitude
                || e.Position.Latitude > _semanticLink.MaxLatitude
                || e.Position.Longitude < _semanticLink.MinLongitude
                || e.Position.Longitude > _semanticLink.MaxLongitude)
            {
                var parameter = new NavigationParameters {{ResultPageViewModel.ParamCalculator, _ecologCalculator}};
                _navigationService.NavigateAsync($"/{nameof(ResultPage)}", parameter);
            }
            else
            {
                _ecologCalculator.PositionCollection.Add(e.Position);
            }
        }
    }
}
