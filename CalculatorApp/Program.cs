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
            Console.WriteLine("Please enter + for Addition");
            Console.WriteLine("Please enter - for Subtraction");
            Console.WriteLine("Please enter * for Multiplication");
            Console.WriteLine("Please enter / for Division");

            string operation = Console.ReadLine();

            if (operation == "+")
            {
                decimal result = numberOne + numberTwo;
                Console.WriteLine("Your result is: " + result + "!");
            }

            else if (operation == "-")
            {
                decimal result = numberOne - numberTwo;
                Console.WriteLine("Your result is: " + result + "!");
            }

            else if (operation == "*")
            {
                decimal result = numberOne * numberTwo;
                Console.WriteLine("Your result is: " + result + "!");
            }

            else if (operation == "/")
            {
                decimal result = numberOne / numberTwo;
                Console.WriteLine("Your result is: " + result + "!");
            }

            Console.ReadLine();


        }
    }
}
