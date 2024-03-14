using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks

namespace codetest3
{
    delegate int CalculatorDelegate(int a, int b);

    class delegates
    {
        
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static void Main()
        {
            CalculatorDelegate calculator = null;

            Console.WriteLine("Enter two num :");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose a calculator Operation \n" +
                " 1. Addition,\t 2. Subtraction,\t 3. Multiplication");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    calculator = Add;
                    break;
                case 2:
                    calculator = Subtract;
                    break;
                case 3:
                    calculator = Multiply;
                    break;
                default:
                    Console.WriteLine("Invalid");
                    return;
            }

            int result = calculator(num1, num2);
            Console.WriteLine($"result {num1} {(choice == 1 ? "+" : choice == 2 ? " - " : " * ")} {num2} is: {result}");
            Console.Read();
        }
    }
}
