
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    public class Class2
    {
        void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the list: ");
            int n = Convert.ToInt32(Console.ReadLine());

            List<int> numbers = new List<int>();

            Console.WriteLine("Enter the elements of the list:");
            for (int i = 0; i < n; i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                numbers.Add(num);
            }

            var result = numbers.Where(num => num * num > 20).Select(num => new { Number = num, Square = num * num });

            Console.WriteLine("Numbers and their squares greater than 20:");
            foreach (var item in result)
            {
                Console.WriteLine("Number: {0}, Square: {1}", item.Number, item.Square);
            }

            Console.ReadLine();
        }
    }
}