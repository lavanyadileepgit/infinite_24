using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array elements : ");
            string[] a = Console.ReadLine().Split(' ');

            Console.WriteLine("The elements are : ");
            foreach (var input in a)
            {
                Console.WriteLine(input);
            }
            int sum = 0;
            foreach(string num in a)
            {
                sum += Convert.ToInt32(num);
            }
            double avg = (sum) / a.Length;
            Console.WriteLine($"average is {avg}");
            Console.ReadLine();


            int min = Convert.ToInt32(a[0]);
            int max = Convert.ToInt32(a[0]);
            for (int i = 0; i < a.Length; i++)
            {
                if (i < min)
                {
                    min = Convert.ToInt32(a[i]);
                }
                if (i > max)
                {
                    max = Convert.ToInt32(a[i]);
                }
            }
            Console.WriteLine($"max is {max}");
            Console.WriteLine($"min is {min}");
            Console.ReadLine();
        }
    }
}

