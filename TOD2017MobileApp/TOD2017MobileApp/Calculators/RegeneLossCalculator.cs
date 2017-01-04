using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOD2017MobileApp.Models;

namespace TOD2017MobileApp.Calculators
{
    public static class RegeneLossCalculator
    {
        public static double CalcEnergy(double drivingPower, double regeneEnergy, Car car, double vehicleSpeed, int efficiency)
        {

            double regeneLoss;
            if (drivingPower >= 0)//力行時
            {
                regeneLoss = 0;
            }

            else
            {//回生時
                regeneLoss = -Math.Abs(drivingPower - regeneEnergy / efficiency * 100 / car.InverterEfficiency);
            }
            return regeneLoss;
        }
    }
}
