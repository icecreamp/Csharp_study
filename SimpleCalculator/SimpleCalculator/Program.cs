/* Simple Calculator.cs
 * Date: 2/19/2023
 * Author: Hyunjin Kim
 * Reference: 'Learn C# By Building Applications' course in Udemy
 */

namespace SimpleCalculator
{
    class Program
    {
        static void Main(String[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                // Get the first number and convert to double
                Console.Write("Enter the first number: ");
                double firstNumber = inputConverter.ConvertInputToNumberic(Console.ReadLine());

                // Get the second number and convert to double
                Console.Write("Enter the second number: ");
                double secondNumber = inputConverter.ConvertInputToNumberic(Console.ReadLine());

                // Get the operator
                Console.Write("Enter the operation: ");
                string operation = Console.ReadLine();

                // Calculate in CalculatorEngine class and get the result
                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                // Display the result
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