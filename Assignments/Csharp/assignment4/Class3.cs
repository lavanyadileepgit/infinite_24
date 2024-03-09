using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    public class Class3
    {
        void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            var result = words.Where(word => word[0] == 'a' && word[word.Length - 1] == 'm');

            Console.WriteLine("Words starting with 'a' and ending with 'm':");
            foreach (var word in result)
            {
                Console.WriteLine(word);
            }

            Console.ReadLine();
        }
    }
}