using System;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float result = 0;
            float numberOne = 0;
            float numberTwo = 0;
            bool endProgram = false;
            bool isNumber = false;
            

            Console.WriteLine("Welcome to the calculator app!");
            Console.WriteLine("Please enter the first number of your calculation");

            numberOne = float.Parse(Console.ReadLine());
            while (isNumber == false)
            {
                if (!float.TryParse(numberOne, out numberOne))
                {
                    Console.WriteLine("Error! Please enter a valid number.");
                }
                else
                {
                    isNumber = true;
                    Console.Write("Please enter the second number for your calculation: ");
                }
            }

            numberTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("What kind of operation would you like to perform?");
            Console.WriteLine("Enter + for Addition");
            Console.WriteLine("Enter - for Subtraction");
            Console.WriteLine("Enter * for Multiplication");
            Console.WriteLine("Enter / for Division");

            

            while (endProgram == false)
            {
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        result = numberOne + numberTwo;
                        endProgram = true;
                        break;

                    case "-":
                        result = numberOne - numberTwo;
                        endProgram = true;
                        break;

                    case "*":
                        result = numberOne * numberTwo;
                        endProgram = true;
                        break;

                    case "/":
                        result = numberOne / numberTwo;
                        endProgram = true;
                        break;

                    default:
                        Console.WriteLine("User input is invalid. Try again.");
                        break;
                }
            }

            Console.WriteLine($"Your result is {result}.");
            Console.WriteLine("Thank you for using our calculator app!");

            Console.ReadLine();


        }
    }
}
