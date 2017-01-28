using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
                CalcEcolog();
            };
            EcologList = new List<double>();
        }

        private void CalcEcolog()
        {
            if (PositionCollection.Count == 2)
            {
                _altitudeBefore = AltitudeCalculator.CalcAltitude(PositionCollection.Last().Latitude, PositionCollection.Last().Longitude);
                //Debug.WriteLine("AltitudeBefore: " + _altitudeBefore.Altitude);
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
                //Debug.WriteLine("DistanceDiff: " + distanceDiff);

                // meter per sec
                var speed = SpeedCalculator.CalcSpeed(positionBefore.Latitude,
                    positionBefore.Longitude,
                    positionBefore.Timestamp.DateTime,
                    positionAfter.Latitude,
                    positionAfter.Longitude,
                    positionAfter.Timestamp.DateTime,
                    positionCurrent.Latitude,
                    positionCurrent.Longitude) / 3.6;
                //Debug.WriteLine("Speed: " + speed);

                if (PositionCollection.Count == 3)
                    _speedBefore = speed;

                var altitude = AltitudeCalculator.CalcAltitude(positionCurrent.Latitude, positionCurrent.Longitude);
                double altitudeDiff = 0;
                if (altitude != null && _altitudeBefore != null)
                {
                    altitudeDiff = altitude.Altitude - _altitudeBefore.Altitude;
                }
                _altitudeBefore = altitude;
                //Debug.WriteLine("AltitudeDiff: " + altitudeDiff);

                double airResistancePower = 0;
                if (speed > 1.0 / 3.6 && distanceDiff > 0)
                    airResistancePower = AirResistanceCalculator.CalcPower(
                        Constants.Rho, Car.GetLeaf().CdValue, Car.GetLeaf().FrontalProjectedArea, speed, speed);
                //Debug.WriteLine("AirResistace: " + airResistancePower);

                double rollingResistancePower = 0;
                if (speed > 1.0 / 3.6 && distanceDiff > 0)
                    rollingResistancePower = RollingResistanceCalculator.CalcPower(
                        Constants.Myu, Car.GetLeaf().Weight, Math.Atan(altitudeDiff / distanceDiff), speed);
                //Debug.WriteLine("rollingResistancePower: " + rollingResistancePower);

                double climbingResistancePower = 0;
                if (speed > 1.0 / 3.6 && distanceDiff > 0)
                    climbingResistancePower = ClimbingResistanceCalculator.CalcPower(
                        Car.GetLeaf().Weight, Math.Atan(altitudeDiff / distanceDiff), speed);
                //Debug.WriteLine("climbingResistancePower: " + climbingResistancePower);

                double accResistancePower = 0;
                if (speed > 1.0 / 3.6 && distanceDiff > 0)
                    accResistancePower = AccResistanceCalculator.CalcPower(
                        _speedBefore,
                        positionBefore.Timestamp.DateTime,
                        speed,
                        positionCurrent.Timestamp.DateTime,
                        Car.GetLeaf().Weight);
                //Debug.WriteLine("accResistancePower: " + accResistancePower);

                double drivingResistancePower =
                    airResistancePower + rollingResistancePower + climbingResistancePower + accResistancePower;

                double torque = 0;
                if (drivingResistancePower > 0 && speed > 0)
                    torque = drivingResistancePower * 1000 * 3600 / speed * Car.GetLeaf().TireRadius /
                             Car.GetLeaf().ReductionRatio;
                //Debug.WriteLine("torque: " + torque);

                var efficiency = EfficiencyCalculator.CalcEfficiency(Car.GetLeaf(), speed, torque).Efficiency;
                //Debug.WriteLine("efficiency: " + efficiency);

                double convertLoss = ConvertLossCaluculator.CalcEnergy(
                    drivingResistancePower, Car.GetLeaf(), speed, efficiency);
                //Debug.WriteLine("convertLoss: " + convertLoss);

                double regeneEnergy = RegeneEnergyCalculator.CalcEnergy(drivingResistancePower,
                    speed, Car.GetLeaf(), efficiency);
                //Debug.WriteLine("regeneEnergy: " + regeneEnergy);

                double regeneLoss = RegeneLossCalculator.CalcEnergy(drivingResistancePower, regeneEnergy,
                    Car.GetLeaf(), speed, efficiency);
                //Debug.WriteLine("regeneLoss: " + regeneLoss);

                double lostEnergy = LostEnergyCalculator.CalcEnergy(convertLoss, regeneLoss, airResistancePower,
                    rollingResistancePower);

                //Debug.WriteLine("LostEnergy: " + lostEnergy);

                EcologList.Add(lostEnergy);
            }
        }
    }
}
