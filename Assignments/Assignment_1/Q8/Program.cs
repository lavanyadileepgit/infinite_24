using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no of elements");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[n];



            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("enter elem" + (i + 1) + ":");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            int total = 0, avg;

            foreach (int numm in numbers)
            {
                total += numm;


            }
            Console.WriteLine($"total is {total}");
            avg = total / n;
            Console.WriteLine($"avg is {avg}");

            Console.ReadKey();
            int min = numbers[0];
            int max = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];

                }
                if (numbers[i] > max)
                {
                    max = numbers[i];


                }

            }
            Console.WriteLine($"minimum is {min}");
            Console.WriteLine($"max is {max}");
            Console.ReadLine();
            Array.Sort(numbers);
            foreach (int numm in numbers)
            {
                Console.WriteLine(numm + "");
            }
            Console.WriteLine();
            Array.Reverse(numbers);
            foreach (int numm in numbers)
            {
                Console.WriteLine(numm + "");
            }
            Console.WriteLine();
            Console.ReadKey();




           

        }
    }
}

