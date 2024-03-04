using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.Write("enter d position of d char to be removed : ");
            int position = int.Parse(Console.ReadLine());

            if (position < 0 || position >= input.Length)
            {
                Console.WriteLine("Invalid position....");
            }
            else
            {
                string result = RemoveChar(input, position);
                Console.WriteLine($"Result is : {result}");
                Console.ReadKey();
            }
        }

        static string RemoveChar(string input, int position)
        {
            string result = " ";
            for (int i = 0; i < input.Length; i++)
            {
                if (i != position)
                {
                    result += input[i];
                }
            }
            return result;
            
        }
    }
}
