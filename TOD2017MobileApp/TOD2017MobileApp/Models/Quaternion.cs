using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOD2017MobileApp.Models
{
    public class Quaternion
    {
        public double T { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Quaternion(double t, double x, double y, double z)
        {
            this.T = t;
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
    }
}
