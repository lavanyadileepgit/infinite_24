using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codetest1
{
    class Class1
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter string:");
            string input = Console.ReadLine();
            string result = interchange(input);
            Console.WriteLine($"Result: {result}");
            Console.ReadLine();
        }

        static string interchange(string str)
        {
            if (str.Length <= 1)
            {
                return str;
            }

            char[] a = str.ToCharArray();
            char fstchar = a[0];
            a[0] = a[str.Length - 1];
            a[str.Length - 1] = fstchar;

            return new string(a);
        }
    }
}
