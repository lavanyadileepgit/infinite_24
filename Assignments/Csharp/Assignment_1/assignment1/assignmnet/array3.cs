using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnet
{
    class array3
    {
        static void Main(string[] args)
        {
            int[] b = { 1, 2, 3, 4, 5 };
            int[] num = new int[b.Length];
            for (int i = 0; i < b.Length; i++)
            {

                num[i] = b[i];
            }
            for (int i = 0; i < num.Length; i++)
            {

                Console.WriteLine(num[i]);
            }
            Console.ReadKey();
        }
    }
}
