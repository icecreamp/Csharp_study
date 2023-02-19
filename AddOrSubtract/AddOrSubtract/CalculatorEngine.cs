using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddOrSubtract
{
    public class CalculatorEngine
    {
        public int Calculator(int firstNum, int secondNum)
        {
            if (firstNum < secondNum || firstNum == secondNum)
            {
                return firstNum + secondNum;
            }
            else
            {
                return firstNum - secondNum;
            }
        }
    }
}
