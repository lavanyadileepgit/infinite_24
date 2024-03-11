using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnet3
{
    public class Nameprog
        {
            public static void Display()
            {
                Console.Write("Enter first name: ");
                string firstName = Console.ReadLine();

                Console.Write("Enter last name: ");
                string lastName = Console.ReadLine();

                Console.WriteLine(firstName.ToUpper());
                Console.WriteLine(lastName.ToUpper());
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Nameprog.Display();
                Console.ReadLine();
            }
        }
    }

    

