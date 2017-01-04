using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;
using TOD2017MobileApp.Models;

namespace TOD2017MobileApp.Calculators
{
    public class AltitudeCalculator
    {
        public static AltitudeDatum CalcAltitude(double latitude, double longitude)
        {
            return Realm.GetInstance()
                .All<AltitudeDatum>()
                .FirstOrDefault(row => row.LowerLatitude <= latitude
                                       && row.UpperLatitude > latitude
                                       && row.LowerLongitude <= longitude
                                       && row.UpperLongitude > longitude);
        }
    }
}
