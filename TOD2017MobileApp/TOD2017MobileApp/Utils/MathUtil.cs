using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TOD2017MobileApp.Models;

namespace TOD2017MobileApp.Utils
{
    public static class MathUtil
    {
        public static double ConvertDegreeToRadian(double degree)
        {
            return degree * Math.PI / 180;
        }

        public static double ConvertSpeedToRev(Car car, double speed)
        {
            return speed * 60 / (car.TireRadius * 2 * Math.PI) * car.ReductionRatio;
        }

        public static double CalcVectorAbsoluteValue(ThreeDimensionalVector vector)
        {
            return Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z);
        }

        public static Quaternion MultiplyQuaternion(Quaternion a, Quaternion b)
        {
            ThreeDimensionalVector vp = new ThreeDimensionalVector(a.Y * b.Z - a.Z * b.Y, a.Z * b.X - a.X * b.Z, a.X * b.Y - a.Y * b.X);
            Quaternion ab = new Quaternion(a.T * b.T, a.T * b.X + b.T * a.X + vp.X, a.T * b.Y + b.T * a.Y + vp.Y, a.T * b.Z + b.T * a.Z + vp.Z);

            return ab;
        }

        public static Tuple<double, double, double> Quartiles(double[] afVal)
        {
            int iSize = afVal.Length;
            int iMid = iSize / 2; //this is the mid from a zero based index, eg mid of 7 = 3;

            double fQ1 = 0;
            double fQ2 = 0;
            double fQ3 = 0;

            if (iSize % 2 == 0)
            {
                //================ EVEN NUMBER OF POINTS: =====================
                //even between low and high point
                fQ2 = (afVal[iMid - 1] + afVal[iMid]) / 2;

                int iMidMid = iMid / 2;

                //easy split 
                if (iMid % 2 == 0)
                {
                    fQ1 = (afVal[iMidMid - 1] + afVal[iMidMid]) / 2;
                    fQ3 = (afVal[iMid + iMidMid - 1] + afVal[iMid + iMidMid]) / 2;
                }
                else
                {
                    fQ1 = afVal[iMidMid];
                    fQ3 = afVal[iMidMid + iMid];
                }
            }
            else if (iSize == 1)
            {
                //================= special case, sorry ================
                fQ1 = afVal[0];
                fQ2 = afVal[0];
                fQ3 = afVal[0];
            }
            else
            {
                //odd number so the median is just the midpoint in the array.
                fQ2 = afVal[iMid];

                if ((iSize - 1) % 4 == 0)
                {
                    //======================(4n-1) POINTS =========================
                    int n = (iSize - 1) / 4;
                    fQ1 = (afVal[n - 1] * .25) + (afVal[n] * .75);
                    fQ3 = (afVal[3 * n] * .75) + (afVal[3 * n + 1] * .25);
                }
                else if ((iSize - 3) % 4 == 0)
                {
                    //======================(4n-3) POINTS =========================
                    int n = (iSize - 3) / 4;

                    fQ1 = (afVal[n] * .75) + (afVal[n + 1] * .25);
                    fQ3 = (afVal[3 * n + 1] * .25) + (afVal[3 * n + 2] * .75);
                }
            }

            return new Tuple<double, double, double>(fQ1, fQ2, fQ3);
        }

		public static int CalculateClassNumber(IList list)
		{
			// スタージェスの公式
			return (int)(1 + Math.Log(list.Count, 2));
		}
    }
}
