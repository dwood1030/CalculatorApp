using System;

namespace CalculatorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float result = 0;

            Console.WriteLine("Welcome to the calculator app!");
            Console.WriteLine("Please enter the first number of your calculation");

            float numberOne = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number of your calcucation");

            float numberTwo = float.Parse(Console.ReadLine());

            Console.WriteLine("What kind of operation would you like to perform?");
            Console.WriteLine("Please enter + for Addition");
            Console.WriteLine("Please enter - for Subtraction");
            Console.WriteLine("Please enter * for Multiplication");
            Console.WriteLine("Please enter / for Division");

            string operation = Console.ReadLine();

            switch(operation)
            {
                case "+":
                    result = numberOne + numberTwo;
                    break;

                case "-":
                    result = numberOne - numberTwo;
                    break;

                case "*":
                    result = numberOne * numberTwo;
                    break;

                case "/":
                    result = numberOne / numberTwo;
                    break;

                default:
                    Console.WriteLine("User input is invalid. Try again.");
                    break;
            }

            Console.WriteLine($"Your result is {result}.");

            Console.ReadLine();
            
            //    if (operation == "+")
            //    {
            //        float result = numberOne + numberTwo;
            //        Console.WriteLine("Your result is: " + result + "!");
            //    }

            //    else if (operation == "-")
            //    {
            //        float result = numberOne - numberTwo;
            //        Console.WriteLine("Your result is: " + result + "!");
            //    }

            //    else if (operation == "*")
            //    {
            //        float result = numberOne * numberTwo;
            //        Console.WriteLine("Your result is: " + result + "!");
            //    }

            //    else if (operation == "/")
            //    {
            //        float result = numberOne / numberTwo;
            //        Console.WriteLine("Your result is: " + result + "!");
            //    }

            //    else
            //    {
            //        Console.WriteLine("Error -- Please enter a valid operation");
            //    }

            //Console.ReadLine();


        }
    }
}
