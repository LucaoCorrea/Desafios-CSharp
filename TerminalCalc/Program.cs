using System;
using TerminalCalc.Models;
using TerminalCalc.Services;

namespace Terminal
{
    class Program
    {
        static void Main()
        {
            var calculator = new Calculator();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== TERMINAL CALCULATOR ===");

                Console.Write("Enter the first number: ");
                if (!double.TryParse(Console.ReadLine(), out double a))
                {
                    Console.WriteLine("Invalid input."); continue;
                }

                Console.Write("Enter the operator (+ - * /): ");
                string op = Console.ReadLine();

                Console.Write("Enter the second number: ");
                if (!double.TryParse(Console.ReadLine(), out double b))
                {
                    Console.WriteLine("Invalid input."); continue;
                }

                try
                {
                    Operation operation = op switch
                    {
                        "+" => new Addition(a, b),
                        "-" => new Subtraction(a, b),
                        "*" => new Multiplication(a, b),
                        "/" => new Division(a, b),
                        _ => throw new InvalidOperationException("Invalid operator.")
                    };

                    double result = calculator.Execute(operation);
                    Console.WriteLine($"\nResult: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine("\nDo you want to continue? (y/n)");
                if (Console.ReadLine().Trim().ToLower() != "y")
                    break;
            }
        }
    }


}