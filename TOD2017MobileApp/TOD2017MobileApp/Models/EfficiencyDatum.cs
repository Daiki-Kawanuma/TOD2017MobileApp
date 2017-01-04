using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;

namespace TOD2017MobileApp.Models
{
    public class EfficiencyDatum : RealmObject
    {
        public int Torque { get; set; }
        public int Rev { get; set; }
        public int Efficiency { get; set; }
    }
}
