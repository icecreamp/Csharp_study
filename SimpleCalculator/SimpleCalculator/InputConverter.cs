using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class InputConverter
    {
        /// <summary>
        /// Convert string to double
        /// </summary>
        /// <param name="argTextInput"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public double ConvertInputToNumberic(string argTextInput)
        {
            double convertedNumber;

            // If we can't convert, throw an exception
            if (!double.TryParse(argTextInput, out convertedNumber)) throw new ArgumentException("Expected a numeric value");
            // Return the converted result
                return convertedNumber;
        }
    }
}
