using System;

namespace UniqueConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Unique Console Calculator!");
            Console.WriteLine("Enter the first number:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            double secondNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("Which operation would you like to perform?");
            Console.WriteLine("+ for addition");
            Console.WriteLine("- for subtraction");
            Console.WriteLine("* for multiplication");
            Console.WriteLine("/ for division");
            Console.WriteLine("% for modulo");
            Console.WriteLine("^ for exponentiation");

            string operation = Console.ReadLine();
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "%":
                    result = firstNumber % secondNumber;
                    break;
                case "^":
                    result = Math.Pow(firstNumber, secondNumber);
                    break;
                default:
                    Console.WriteLine("Invalid operation entered. Please try again.");
                    return;
            }

            Console.WriteLine("The result is " + result);
        }
    }
}
