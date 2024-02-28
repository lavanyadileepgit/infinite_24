using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codetest3
{
    class Program
    {
        static void Main(string[] args)
        {
            
                Console.WriteLine("enter 3 integers:");
                int n1 = Convert.ToInt32(Console.ReadLine());
                int n2 = Convert.ToInt32(Console.ReadLine());
                int n3 = Convert.ToInt32(Console.ReadLine());

                int l = larg(n1, n2, n3);

                Console.WriteLine($"largest number is :{l}");
                Console.ReadLine();
        }

            static int larg(int n1, int n2, int n3)
            {
                if (n1 >= n2 && n1 >= n3)
                {
                    return n1;
                }
                else if (n2 >= n1 && n2 >= n3)
                {
                    return n2;
                }
                else
                {
                    return n3;
                }
            }
    }

}

