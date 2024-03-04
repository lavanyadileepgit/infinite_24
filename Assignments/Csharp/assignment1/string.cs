using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class @string
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a word");
            string str = Console.ReadLine();
            int n = str.Length;
            Console.WriteLine($"word length is {n} and word is {str}");
            Console.ReadLine();


            Console.WriteLine("enter string");
            string s = Console.ReadLine();
            string e = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                e += s[i];
            }
            Console.WriteLine(e);
            Console.ReadLine();

            Console.WriteLine("enter first string");
            string s1 = Console.ReadLine();
            Console.WriteLine("enter second string");
            string s2 = Console.ReadLine();
            Console.WriteLine(s1 == s2 ? "same" : "different");
            Console.ReadLine();
        }
    }
}
