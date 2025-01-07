using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int choice = 0;

                Console.WriteLine("0. Exit \n1. Addition \n2. Subtraction \n3. Multiplication \n4. Division");
                Console.WriteLine("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        {
                            Environment.Exit(0);
                            break;
                        }
                    case 1:
                        {
                            Console.WriteLine("Enter 1st number");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter 2nd number");
                            int num2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Addition is " + (num1 + num2));
                            Console.WriteLine();

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter 1st number");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter 2nd number");
                            int num2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Subtraction is " + (num1 - num2));
                            Console.WriteLine();

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter 1st number");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter 2nd number");
                            int num2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Multiplication is " + (num1 * num2));
                            Console.WriteLine();

                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter 1st number");
                            int num1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter 2nd number");
                            int num2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Division is " + (num1 / num2));
                            Console.WriteLine();

                            break;
                        }
                }
            }
        }
    }
}
