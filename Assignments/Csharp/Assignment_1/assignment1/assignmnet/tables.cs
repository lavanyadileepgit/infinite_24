using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnet
{
    class tables
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= 10; i++)
            {
                int res = n * i;
                Console.WriteLine($"{n} * {i} = {res}");

            }
            Console.ReadLine();
        }
    }
}
