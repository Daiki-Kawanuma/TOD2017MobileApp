using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOD2017MobileApp.Calculators
{
    public static class AccCalculator
    {
        public static double CalcAcc(double latitudeBefore, double longitudeBefore,
            double latitudeThis, double longitudeThis,
            double latitudeAfter, double longitudeAfter, double samplingTime)
        {
            //中間差分法による導出
            return (DistanceCalculator.CalcDistance(latitudeThis, longitudeThis, latitudeAfter, longitudeAfter)
                - DistanceCalculator.CalcDistance(latitudeBefore, longitudeBefore, latitudeThis, longitudeBefore)) / Math.Pow(samplingTime, 2);
        }
    }
}
