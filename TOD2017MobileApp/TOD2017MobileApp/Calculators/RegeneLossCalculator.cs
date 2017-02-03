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

		public static double CalcEnergyPreVer(double drivingPower, double speed, int efficiency)
		{
			double regeneLimit = 0.15 * 9.8 * 1600;
			double regeneLoss;
			if (drivingPower > 0)
			{
				regeneLoss = 0;
			}
			else if (speed * 3.6 < 7)
			{
				regeneLoss = drivingPower;
			}
			else if (drivingPower > -regeneLimit * speed * 0.278 * 0.000001)
			{
				regeneLoss = 0;
			}
			else 
			{
				regeneLoss = drivingPower + regeneLimit * speed * 0.278 * 0.000001;
			}

			return regeneLoss;
		}
    }
}
