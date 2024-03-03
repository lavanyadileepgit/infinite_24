using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter the number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine("its positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
            Console.ReadKey();
        }
    }
}
