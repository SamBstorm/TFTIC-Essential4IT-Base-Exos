using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo17_Temperature
{
    public struct Celsius
    {
        public double temperature;

        public Fahrenheit Convert()
        {
            Fahrenheit result;

            result.temperature = temperature * 1.8 + 32;

            return result;
        }
    }

    public struct Fahrenheit
    {
        public double temperature;

        public Celsius Convert()
        {
            Celsius result;

            result.temperature = (temperature - 32) * (5 / 9.0);

            return result;
        }
    }
}
