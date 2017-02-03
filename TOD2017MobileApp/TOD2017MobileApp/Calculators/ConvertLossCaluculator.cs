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
													   * ((1.0f - (efficiency + 0.0f) / 100.0f * car.InverterEfficiency));
			}
			else
			{
				convertLoss = ConsumedEnergyCaluculator.CalcEnergy(drivingPower, car, vehicleSpeed, efficiency)
					* ((1.0f / (efficiency + 0.0f) * 100.0f / car.InverterEfficiency - 1.0f));
			}
			return convertLoss;
		}

		public static double CalcEnergyPreVer(double drivingPower, double speed, int efficiency)
		{
			double regeneLimit = 0.15 * 9.8 * 1600;
			double convertLoss;

			if (drivingPower > 0)
			{
				convertLoss = (drivingPower / (efficiency * 0.95) * 100) - drivingPower;
			}
			else if (speed * 3.6 < 7)
			{
				convertLoss = 0;
			}
			else if (drivingPower > -regeneLimit * speed * 0.278 * 0.000001)
			{
				convertLoss = drivingPower - (drivingPower * (efficiency * 0.95) / 100);
			}
			else 
			{
				convertLoss = -regeneLimit * speed * 0.278 * 0.000001
													  - (-regeneLimit * speed * 0.278 * 0.000001 * (efficiency * 0.95) / 100);
			}
			return convertLoss;
		}
	}
}
