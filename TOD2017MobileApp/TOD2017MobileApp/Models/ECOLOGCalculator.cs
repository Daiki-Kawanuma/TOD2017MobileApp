using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;
using TOD2017MobileApp.Calculators;
using TOD2017MobileApp.Calculators.Components;

namespace TOD2017MobileApp.Models
{
    // ReSharper disable once InconsistentNaming
    public class ECOLOGCalculator
    {
        public ObservableCollection<Position> PositionCollection { get; set; }
        public IList<double> EcologList { get; set; }
        private AltitudeDatum _altitudeBefore;
        private double _speedBefore;

        public void Init()
        {
            PositionCollection = new ObservableCollection<Position>();
            PositionCollection.CollectionChanged += (sender, args) =>
            {
                Task.Run(() =>
                {
                    CalcEcolog();
                });
            };
            EcologList = new List<double>();
        }

        private void CalcEcolog()
        {
            if (PositionCollection.Count == 2)
            {
                _altitudeBefore = AltitudeCalculator.CalcAltitude(PositionCollection.Last().Latitude, PositionCollection.Last().Longitude);
            }
            else if (PositionCollection.Count > 2)
            {
                var positionBefore = PositionCollection[PositionCollection.Count - 3];
                var positionCurrent = PositionCollection[PositionCollection.Count - 2];
                var positionAfter = PositionCollection[PositionCollection.Count - 1];

                var distanceDiff = DistanceCalculator.CalcDistance(positionBefore.Latitude,
                    positionBefore.Longitude,
                    positionCurrent.Latitude,
                    positionCurrent.Longitude);

                // meter per sec
                var speed = SpeedCalculator.CalcSpeed(positionBefore.Latitude,
                    positionBefore.Longitude,
                    positionBefore.Timestamp.DateTime,
                    positionAfter.Latitude,
                    positionAfter.Longitude,
                    positionAfter.Timestamp.DateTime,
                    positionCurrent.Latitude,
                    positionCurrent.Longitude) / 3.6;

                if (PositionCollection.Count == 3)
                    _speedBefore = speed;

                var altitude = AltitudeCalculator.CalcAltitude(positionCurrent.Latitude, positionCurrent.Longitude);
                double altitudeDiff = 0;
                if (altitude != null && _altitudeBefore != null)
                {
                    altitudeDiff = altitude.Altitude - _altitudeBefore.Altitude;
                }
                _altitudeBefore = altitude;

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
                        _speedBefore,
                        positionBefore.Timestamp.DateTime,
                        speed,
                        positionCurrent.Timestamp.DateTime,
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

                EcologList.Add(LostEnergyCalculator.CalcEnergy(convertLoss, regeneLoss, airResistancePower,
                    rollingResistancePower));
            }
        }
    }
}
