using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;

namespace TOD2017MobileApp.Models
{
    public class GraphDatum : RealmObject
    {
        public int SemanticLinkId { get; set; }
        public int TripId { get; set; }
        public DateTimeOffset Date { get; set; }
        public float ConsumedElectricEnergy { get; set; }
        public float LostEnergy { get; set; }
        public float ConvertLoss { get; set; }
        public float AirResistance { get; set; }
        public float RollingResistance { get; set; }
        public float RegeneLoss { get; set; }
        public int TransitTime { get; set; }
    }
}
