using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOrSubtract
{
    public class InputConverter
    {
        public int ConvertInputToNumber(string input)
        {
            int convertedNum;

            if (!int.TryParse(input, out convertedNum)) throw new ArgumentException("Please enter a number");
            return convertedNum;
        }
    }
}
