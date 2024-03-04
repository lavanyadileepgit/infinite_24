using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnet
{
    class number
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("enter n1");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter n2");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(test(n1, n2));
            Console.ReadLine();


        }
        public static int test(int a, int b)
        {
            return (a == b) ? (a + b) * 3 : (a + b);
        }
    }
}
