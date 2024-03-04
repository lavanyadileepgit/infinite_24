using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter n1 value");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter n2 value");
            int n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 == n2)
            {
                Console.WriteLine($"{n1} and {n2} are same");
            }
            else
            {
                Console.WriteLine("they are not same");
            }
            Console.ReadKey();
        }
    }
}
