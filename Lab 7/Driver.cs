using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace Lab_7
{
    public class Driver
    {
        private static void Calculate() {
            Calculator calculator = new();
            Console.Write("0 - Exit\r\n1 - Addition\r\n2 - Subtraction\r\n3 - Multiplication\r\n4 - Division\r\nPlease Choose an Option: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 0)
            {
                System.Environment.Exit(0);
            }
            Console.Write("Please enter the first number: ");
            float num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            float num2 = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    Console.WriteLine(calculator.Add(num1, num2));
                    break;
                case 2:
                    Console.WriteLine(calculator.Subtract(num1, num2));
                    break;
                case 3:
                    Console.WriteLine(calculator.Multiply(num1, num2));
                    break;
                case 4:
                    Console.WriteLine(calculator.Divide(num1, num2));
                    break;
                case 0:
                    System.Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Not a valid choice");
                    break;

            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            while(true)
            {
                Calculate();
            }
        }
    }
}