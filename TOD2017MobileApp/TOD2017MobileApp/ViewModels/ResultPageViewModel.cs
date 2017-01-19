using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using Plugin.Geolocator.Abstractions;
using Prism.Navigation;
using Reactive.Bindings;
using TOD2017MobileApp.Calculators;
using TOD2017MobileApp.Calculators.Components;
using TOD2017MobileApp.Models;
using TOD2017MobileApp.Views;

namespace TOD2017MobileApp.ViewModels
{
    public class ResultPageViewModel : BindableBase, INavigationAware
    {
        public const string ParamPositions = "positions";
        public const string ParamSemanticLink = "semantic_link";
        private readonly INavigationService _navigationService;
        private IList<Position> _positions;
        private double _lostEnergy;
        private int _transitTime;
        private ECGModel _ecgModel;
        public ReactiveProperty<PlotModel> PlotModel { get; set; }
        public ReactiveProperty<bool> IsBusy { get; set; }

        public ResultPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            PlotModel = new ReactiveProperty<PlotModel>();
            IsBusy = new ReactiveProperty<bool> { Value = true };
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public async void OnNavigatedTo(NavigationParameters parameters)
        {
            _positions = parameters[ParamPositions] as List<Position>;
            var semanticLink = parameters[ParamSemanticLink] as SemanticLink;
            _ecgModel = ECGModel.GetECGModel(semanticLink);

            await Task.Run(() =>
            {
                _lostEnergy = CalcLostEnergy();
                _transitTime = (int)
                    (_positions.Last().Timestamp.DateTime - _positions.First().Timestamp.DateTime).TotalSeconds;
            });

            PlotModel.Value = CreatePlotModel();

            var timer = new ReactiveTimer(TimeSpan.FromSeconds(5));
            timer.Subscribe(v =>
            {
                timer.Stop();
                _navigationService.NavigateAsync($"/{nameof(MapPage)}");
            });
        }

        private double CalcLostEnergy()
        {
            double lostEnergy = 0;
            AltitudeDatum altitudeBefore = AltitudeCalculator.CalcAltitude(_positions[0].Latitude, _positions[0].Longitude);
            double speedBefore = 0;

            for (int i = 1; i < _positions.Count - 1; i++)
            {
                var distanceDiff = DistanceCalculator.CalcDistance(_positions[i - 1].Latitude,
                    _positions[i - 1].Longitude,
                    _positions[i].Latitude,
                    _positions[i].Longitude);

                // meter per sec
                var speed = SpeedCalculator.CalcSpeed(_positions[i - 1].Latitude,
                    _positions[i - 1].Longitude,
                    _positions[i - 1].Timestamp.DateTime,
                    _positions[i + 1].Latitude,
                    _positions[i + 1].Longitude,
                    _positions[i + 1].Timestamp.DateTime,
                    _positions[i].Latitude,
                    _positions[i].Longitude) / 3.6;

                var altitude = AltitudeCalculator.CalcAltitude(_positions[i].Latitude, _positions[i].Longitude);
                double altitudeDiff = 0;
                if (altitude != null && altitudeBefore != null)
                {
                    altitudeDiff = altitude.Altitude - altitudeBefore.Altitude;
                }
                altitudeBefore = altitude;

                double airResistancePower = 0;
                if (speed > 1.0 / 3.6 && distanceDiff > 0)
                    airResistancePower = AirResistanceCalculator.CalcPower(
                        Constants.Rho, Car.GetLeaf().CdValue, Car.GetLeaf().FrontalProjectedArea, speed, speed);

                double rollingResistancePower = 0;
                if (speed > 1 && distanceDiff > 0)
                    rollingResistancePower = RollingResistanceCalculator.CalcPower(
                        Constants.Myu, Car.GetLeaf().Weight, Math.Atan(altitudeDiff / distanceDiff), speed);

                double climbingResistancePower = 0;
                if (speed > 1 && distanceDiff > 0)
                    climbingResistancePower = ClimbingResistanceCalculator.CalcPower(
                        Car.GetLeaf().Weight, Math.Atan(altitudeDiff / distanceDiff), speed);

                double accResistancePower = 0;
                if (speed > 1 && distanceDiff > 0)
                    accResistancePower = AccResistanceCalculator.CalcPower(
                        speedBefore,
                        _positions[i - 1].Timestamp.DateTime,
                        speed,
                        _positions[i].Timestamp.DateTime,
                        Car.GetLeaf().Weight);

                double drivingResistancePower =
                    airResistancePower + rollingResistancePower + climbingResistancePower + accResistancePower;

                double torque = 0;
                if (drivingResistancePower > 0 && speed > 0)
                    torque = drivingResistancePower * 1000 * 3600 / speed * Car.GetLeaf().TireRadius /
                             Car.GetLeaf().ReductionRatio;

                var efficiency = EfficiencyCalculator.CalcEfficiency(Car.GetLeaf(), speed, torque).Efficiency;

                double convertLoss = ConvertLossCaluculator.CalcEnergy(
                    drivingResistancePower, Car.GetLeaf(), speed, efficiency);

                double regeneEnergy = RegeneEnergyCalculator.CalcEnergy(drivingResistancePower,
                    speed, Car.GetLeaf(), efficiency);

                double regeneLoss = RegeneLossCalculator.CalcEnergy(drivingResistancePower, regeneEnergy,
                    Car.GetLeaf(), speed, efficiency);

                lostEnergy += LostEnergyCalculator.CalcEnergy(convertLoss, regeneLoss, airResistancePower,
                    rollingResistancePower);

                speedBefore = speed;
            }

            return lostEnergy;
        }

        private PlotModel CreatePlotModel()
        {
            var model = new PlotModel();

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

            var scatterSeries = new ScatterSeries
            {
                MarkerFill = OxyColors.LightGray
            };

            foreach (var datum in _ecgModel.GraphData)
            {
                scatterSeries.Points.Add(new ScatterPoint(datum.TransitTime, datum.LostEnergy));
            }
            model.Series.Add(scatterSeries);

            var trip = new ScatterSeries
            {
                MarkerFill = OxyColors.GreenYellow,
                Points = { new ScatterPoint(_transitTime, _lostEnergy) }
            };
            model.Series.Add(trip);

            return model;
        }
    }
}
