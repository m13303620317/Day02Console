using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02Console
{
    public static class Calculator
    {
        // Add two numbers together
        public static void Add(double a, double b) 
        {
            Console.WriteLine($"{a} + {b} = " + (a + b));
        }

        // Subtract two numbers
        public static void Subtract(double a, double b)
        {
            Console.WriteLine($"{a} - {b} = " + (a - b));
        }

        // Multiply two numbers
        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"{a} * {b} = " + (a * b));
        }

        // Divide two numbers by one
        public static void Divide(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("The divisor can not be zero!");
            }
            else
            {
                Console.WriteLine($"{a} / {b} = " + (a / b));
            }
        }

        // Radication
        public static void Radication(double a)
        {
            if (a < 0)
            {
                Console.WriteLine("The radicand can not less than 0!");
            }
            else
            {
                Console.WriteLine($"The square root of {a} is " + Math.Sqrt(a));
            }
        }

        // Power
        public static void Power(double a, double b)
        {
            Console.WriteLine($"{a} ^ {b} = " + Math.Pow(a, b));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test
            Calculator.Add(1.5, 3);
            Calculator.Subtract(5, 6);
            Calculator.Multiply(2, 1.9);
            Calculator.Divide(8, 2);
            Calculator.Divide(5, 0);
            Calculator.Radication(4);
            Calculator.Radication(-1);
            Calculator.Power(4, 1.5);

            Console.WriteLine("Welcome to access C# Calcultor, Now we will guide you to use the application.");
            Console.WriteLine("--------------------------------------------------");

            bool close = false;

            do
            {
                /** Number a */
                string a = "";
                /** Number b */
                string b = "";

                double numA;
                double numB;

                // When what you type is a number, Exit the loop.
                Console.WriteLine("Please type a number, then press Enter.");
                a = Console.ReadLine();
                while (!double.TryParse(a, out numA))
                {
                    Console.WriteLine($"\"{a}\" is not a number, Please type a integer or a decimal.");
                    a = Console.ReadLine();
                }

                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.WriteLine("\tr - Radication");
                Console.WriteLine("\tp - Power");
                Console.WriteLine("Your option? ");

                // Operator
                string op = Console.ReadLine();
                while (op != "a" && op != "s" && op != "m" && op != "d" && op != "r" && op != "p")
                {
                    Console.WriteLine("What you type is incorrect, Please choose a operator again.");
                    Console.WriteLine("\ta - Add");
                    Console.WriteLine("\ts - Subtract");
                    Console.WriteLine("\tm - Multiply");
                    Console.WriteLine("\td - Divide");
                    Console.WriteLine("\tr - Radication");
                    Console.WriteLine("\tp - Power");
                    Console.WriteLine("Your option? ");
                    op = Console.ReadLine();
                }

                if (op == "r")
                {
                    // Radication
                    Calculator.Radication(numA);
                }
                else
                {
                    // When what you choose is not "r", type another number
                    Console.WriteLine("Please type another number, then press Enter");
                    b = Console.ReadLine();
                    // When what you type is a number, Exit the loop.
                    while (!double.TryParse(b, out numB))
                    {
                        Console.WriteLine($"\"{b}\" is not a number, Please type a integer or a decimal");
                        b = Console.ReadLine();
                    }

                    // Use a switch statement to do the math.
                    switch (op)
                    {
                        case "a":
                            Calculator.Add(numA, numB);
                            break;
                        case "s":
                            Calculator.Subtract(numA, numB);
                            break;
                        case "m":
                            Calculator.Multiply(numA, numB);
                            break;
                        case "d":
                            Calculator.Divide(numA, numB);
                            break;
                        case "p":
                            Calculator.Power(numA, numB);
                            break;
                        default:
                            Console.WriteLine("An unexpected exception has occurred.");
                            break;
                    }
                }

                Console.WriteLine("Continue? (Y/N)");
                string co = Console.ReadLine();
                while (co.ToLower() != "y" && co.ToLower() != "n")
                {
                    Console.WriteLine("Continue? (Y/N)");
                    co = Console.ReadLine();
                }
                if (co.ToLower() == "n")
                {
                    close = true;
                }
            }
            while (!close);
            
            // Wait for the user to respond before closing.
            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }
    }
}
