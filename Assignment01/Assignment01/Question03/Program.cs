using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char choice;
            int num1, num2;

            do
            {
                Console.WriteLine("\nCalculator Menu:");
                Console.WriteLine("+ : Addition");
                Console.WriteLine("- : Subtraction");
                Console.WriteLine("* : Multiplication");
                Console.WriteLine("/ : Division");
                Console.WriteLine("e : Exit");
                Console.WriteLine("\nEnter operation (+, -, *, /, e): ");

                choice = Console.ReadLine()[0];

                if (choice == 'e')
                    break;

                if (choice == '+' || choice == '-' || choice == '*' || choice == '/')
                {
                    Console.Write("Enter 1st number: ");
                    num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter 2nd number: ");
                    num2 = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case '+':
                            Console.WriteLine($"Result: {num1} + {num2} = {num1 + num2}");
                            break;
                        case '-':
                            Console.WriteLine($"Result: {num1} - {num2} = {num1 - num2}");
                            break;
                        case '*':
                            Console.WriteLine($"Result: {num1} * {num2} = {num1 * num2}");
                            break;
                        case '/':
                            Console.WriteLine($"Result: {num1} / {num2} = {num1 / num2}");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Select valid operation");
                }

            } while (true);

        }
    }
}