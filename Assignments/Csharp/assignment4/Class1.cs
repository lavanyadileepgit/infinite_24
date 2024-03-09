using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment4
{
    class Program
    {
        public const int TotalFare = 500;

        static void Main()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            double concession = 0;
            switch (age)
            {
                case int a when a < 18:
                    concession = 0.5;
                    break;
                case int a when a >= 60:
                    concession = 0.3;
                    break;
            }

            double payableAmount = TotalFare - (TotalFare * concession);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Total Fare: {TotalFare}");
            Console.WriteLine($"Concession Percentage: {concession}");
            Console.WriteLine($"Payable Amount: {payableAmount}");
            Console.Read();
        }
    }

}