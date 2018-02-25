using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiServer
{
    class Function
    {
        public static double Cosinus(double x)
        {
            return Math.Cos(x);
        }

        public static double Sinus(double x)
        {
            return Math.Sin(x);
        }

        public static double Tangens(double x)
        {
            return Math.Tan(x);
        }

        public static double Ctangens(double x)
        {
            return Cosinus(x) / Sinus(x);
        }

        public static double GetSqrt(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
