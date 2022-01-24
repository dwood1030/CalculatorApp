using System;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator app!");
            Console.WriteLine("Please enter the first number of your calculation");

            decimal numberOne = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Please enter the second number of your calcucation");

            decimal numberTwo = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("What kind of operation would you like to perform?");
            Console.WriteLine("Please enter 1 for Addition");
            Console.WriteLine("Please enter 2 for Subtraction");
            Console.WriteLine("Please enter 3 for Multiplication");
            Console.WriteLine("Please enter 4 for Division");

            decimal operation = Convert.ToDecimal(Console.ReadLine());

            if (operation == 1)
            {
                decimal result = numberOne + numberTwo;
                Console.WriteLine("Your result is: " + result + "!");
            }

            else if (operation == 2)
            {
                decimal result = numberOne - numberTwo;
                Console.WriteLine("Your result is: " + result + "!");
            }

            else if (operation == 3)
            {
                decimal result = numberOne * numberTwo;
                Console.WriteLine("Your result is: " + result + "!");
            }

            else if (operation == 4)
            {
                decimal result = numberOne / numberTwo;
                Console.WriteLine("Your result is: " + result + "!");
            }
            
        }
    }
}
