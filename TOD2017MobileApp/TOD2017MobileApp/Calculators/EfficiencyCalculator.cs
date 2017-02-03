using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realms;
using TOD2017MobileApp.Models;
using TOD2017MobileApp.Utils;

namespace TOD2017MobileApp.Calculators
{
    public class EfficiencyCalculator
    {
        public static EfficiencyDatum CalcEfficiency(Car car, double speed, double torque)
        {
            double rpm = MathUtil.ConvertSpeedToRev(car, speed);

            var efficiency = Realm.GetInstance()
                .All<EfficiencyDatum>()
                .Where(v => v.Torque == (int)Math.Round(torque))
                .FirstOrDefault(v => v.Rev == (int)(Math.Round(rpm / 10)) * 10);

            if (efficiency == null)
            {
                //Debug.WriteLine("****** Efficiency is NULL *********");
                efficiency = new EfficiencyDatum { Efficiency = 70 };
            }

            return efficiency;
        }
    }
}
