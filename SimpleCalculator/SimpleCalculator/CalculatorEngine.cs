using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class CalculatorEngine
    {
        /// <summary>
        /// Calculates the inputs
        /// </summary>
        /// <param name="argOperation"></param>
        /// <param name="argFirstNumber"></param>
        /// <param name="argSecondNumber"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public double Calculate(String argOperation, double argFirstNumber, double argSecondNumber)
        {
            // Stores the result of the calculation
            double result;

            switch(argOperation.ToLower())
            {
                // Addition
                case "add":
                case "+":
                    result = argFirstNumber + argSecondNumber;
                    break;

                // Subtraction
                case "subtract":
                case "-":
                    result = argFirstNumber - argSecondNumber;
                    break;

                // Multiply
                case "multiply":
                case "*":
                    result = argFirstNumber * argSecondNumber;
                    break;
                
                // Division
                case "divide":
                case "/":
                    result = argFirstNumber / argSecondNumber;
                    break;
                // When the operation is not recognized
                default:
                    throw new InvalidOperationException("Specified operation is not recognized.");

            }
            // Retrun the result to the Program.cs
            return result;
        }
    }
}
