using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnet3
{
    public class Doctor
        {
            public int RegnNo { get; set; }
            public string Name { get; set; }
            public int FeesCharged { get; set; }
        }

        class properties
        {
            static void Main(string[] args)
            {
                Doctor doc = new Doctor();

                Console.Write("Enter registration number: ");
                doc.RegnNo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter name: ");
                doc.Name = Console.ReadLine();

                Console.Write("Enter fees charged: ");
                doc.FeesCharged = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Registration number: " + doc.RegnNo);
                Console.WriteLine("Name: " + doc.Name);
                Console.WriteLine("Fees charged: " + doc.FeesCharged);

                Console.ReadLine();
            }
        }
}

