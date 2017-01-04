using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOD2017MobileApp.Calculators.Components;

namespace TOD2017MobileApp.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public double Battery { get; set; }
        public double Weight { get; set; }
        public double TireRadius { get; set; }
        public double ReductionRatio { get; set; }
        public double CdValue { get; set; }
        public double FrontalProjectedArea { get; set; }
        public double InverterEfficiency { get; set; }
        public double MaxDrivingForce { get; set; }
        public double MaxDrivingPower { get; set; }

        public static Car GetLeaf()
        {
            return new Car
            {
                Battery = 24,
                Weight = 1600,
                TireRadius = 0.3155f,
                ReductionRatio = 7.9377f,
                CdValue = 0.28f,
                FrontalProjectedArea = 2.19f,
                InverterEfficiency = 0.95,
                MaxDrivingPower = -30,
                MaxDrivingForce = -0.15 * Constants.GravityResistanceCoefficient * 1600
            };
        }
    }
}
