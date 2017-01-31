using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOD2017MobileApp.Models;

namespace TOD2017MobileApp.Calculators
{
    public static class ConvertLossCaluculator
    {
        public static double CalcEnergy(double drivingPower, Car car, double vehicleSpeed, int efficiency)
        {
            double convertLoss;

            if (drivingPower >= 0)
            {
                convertLoss = ConsumedEnergyCaluculator.CalcEnergy(drivingPower, car, vehicleSpeed, efficiency)
                    * ((1.0f - (efficiency + 0.0f) / 100.0f) * car.InverterEfficiency);
            }
            else
            {
                convertLoss = ConsumedEnergyCaluculator.CalcEnergy(drivingPower, car, vehicleSpeed, efficiency)
                    * ((1.0f / (efficiency + 0.0f) * 100.0f - 1.0f) / car.InverterEfficiency);
            }
            return convertLoss;
        }
    }
}
