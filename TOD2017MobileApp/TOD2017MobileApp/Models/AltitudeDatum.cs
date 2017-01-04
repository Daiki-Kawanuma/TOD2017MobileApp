using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;

namespace TOD2017MobileApp.Models
{
    public class AltitudeDatum : RealmObject
    {
        public double LowerLatitude { get; set; }
        public double LowerLongitude { get; set; }
        public double UpperLatitude { get; set; }
        public double UpperLongitude { get; set; }
        public double Altitude { get; set; }
    }
}
