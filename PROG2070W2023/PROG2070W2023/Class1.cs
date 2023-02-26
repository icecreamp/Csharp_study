using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070W2023
{
        public static class Temp
        {
            public static string TemperatureConverter(float ambientTemp)
            {
                string outputTemp = "";

                if (ambientTemp >= 36.0f && ambientTemp <= 40.0f)
                {
                    outputTemp = "There is a high degree of heat outside";
                }
                else if (ambientTemp >= 26.0f && ambientTemp <= 35.9f)
                {
                    outputTemp = "It is quite hot outside";
                }
                else if (ambientTemp >= 16.0f && ambientTemp <= 25.9f)
                {
                    outputTemp = "It is comfortable outside";
                }
                else if (ambientTemp >= 0.0f && ambientTemp <= 15.9f)
                {
                    outputTemp = "It is somewhat cold";
                }
                else
                {
                    outputTemp = "The temperature you is not within the acceptable range";
                }
                return outputTemp;
            }
        }
}


