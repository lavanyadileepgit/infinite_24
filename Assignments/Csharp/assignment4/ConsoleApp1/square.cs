using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class square
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a list of numbers (comma-separated): ");
            string input = Console.ReadLine();
            List<int> numbers = input.Split(',').Select(int.Parse).ToList();

            var query = numbers.Select(n => new { Number = n, Square = n * n })
                               .Where(x => x.Square > 20)
                               .Select(x => x.Square);

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
    }
}
