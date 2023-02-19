/* AddOrSubstract
 * Date: 2/19/2023
 * Author: Hyunjin Kim
 */

//This exercise is about you taking 2 numerical inputs and adding the 2 numbers if the first number is less than or equal the second number.
//But subtract the second number from the first number if the first number is greater than the second number.

using System.ComponentModel;

namespace AddOrSubtract
{
    class Program
    {
        static void Main(String[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                Console.Write("Please enter the first number: ");
                int firstNum = inputConverter.ConvertInputToNumber(Console.ReadLine());
                Console.Write("Please enter the second number: ");
                int secondNum = inputConverter.ConvertInputToNumber(Console.ReadLine());

                int result = calculatorEngine.Calculator(firstNum, secondNum);

                Console.WriteLine($"Result: {result}");

            }

            // Display an error message
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}