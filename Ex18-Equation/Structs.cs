using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18_Equation
{
    public struct Equation2degre
    {
        public double A;
        public double B;
        public double C;

        public bool Resoudre(out double? X1, out double? X2)
        {
            bool result;
            double delta = (B * B) - (4 * A * C);

            if(delta == 0)
            {
                X1 = -B / (2 * A);
                X2 = X1;
                result = true;
            }
            else if(delta > 0)
            {
                X1 = (-B - Math.Sqrt(delta))/(2*A);
                X2 = (-B + Math.Sqrt(delta))/(2*A);
                result = true;
            }
            else
            {
                X1 = null;
                X2 = null;
                result = false;
            }

            return result;
        }

        public bool ResoudreV2(out double? X1, out double? X2)
        {
            double delta = (B * B) - (4 * A * C);
            X2 = X1 = null;

            if (delta < 0) return false;
            if (delta > 0)
            {
                X1 = (-B - Math.Sqrt(delta)) / (2 * A);
                X2 = (-B + Math.Sqrt(delta)) / (2 * A);
            }
            else
            {
                X2 = X1 = -B / (2 * A);
            }
            return true;
        }

        public bool ResoudreV3(out double? X1, out double? X2)
        {
            double delta = (B * B) - (4 * A * C);
            X2 = X1 = null;

            if (delta < 0) return false;
            X1 = (-B - Math.Sqrt(delta)) / (2 * A);
            X2 = (-B + Math.Sqrt(delta)) / (2 * A);
            return true;
        }
    }
}
