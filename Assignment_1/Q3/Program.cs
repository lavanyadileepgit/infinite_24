using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    class Program
    {
        static void Main(string[] args)
        {
            float result = 0;

            Console.WriteLine("Enter first number");
            float num1 = float.Parse(Console.ReadLine());


            Console.WriteLine("Enter second number");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter operator");
            string op = Console.ReadLine();

            switch (op)
            {

                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
                case "%":
                    result = num1 % num2;
                    break;



            }
            Console.WriteLine("Result = " + result);
            Console.ReadKey();
        }
    }
}
