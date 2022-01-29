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
            bool isNum = false;
            

            Console.WriteLine("Welcome to the calculator app!");
            Console.Write("Please enter the first number of your calculation: ");

            while (isNumber == false)
            {
                string inputOne = Console.ReadLine();

                if (!float.TryParse(inputOne, out numberOne))
                {
                    Console.WriteLine("Error! Please enter a valid number.");
                }
                else
                {
                    isNumber = true;
                    Console.Write("Please enter the second number for your calculation: ");
                }
            }

            while (isNum == false)
            {
                string inputTwo = Console.ReadLine();

                if (!float.TryParse(inputTwo, out numberTwo))
                {
                    Console.WriteLine("Error! Please enter a valid number.");
                }
                else
                {
                    isNum = true;
                    Console.WriteLine("What kind of operation would you like to perform?");
                }
            }

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
