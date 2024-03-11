using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnet3
{
    class count
        {
            static void Main(string[] args)
            {
                Console.Write("Enter a string: ");
                string input = Console.ReadLine();

                Console.Write("Enter a letter to count: ");
                char letter = Console.ReadKey().KeyChar;

                int count = input.ToLower().Split(letter).Length - 1;
                Console.WriteLine("\nThe letter '{0}' appears {1} times in the string.", letter, count);
                Console.ReadLine();
            }
        }
    }

