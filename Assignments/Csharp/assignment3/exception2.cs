using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnet3
{
   class exception2
        {
            public static void Merit(int marks, int fees)
            {
                double scholarshipAmount = 0;

                if (marks >= 70 && marks <= 80)
                {
                    scholarshipAmount = 0.2 * fees;
                }
                else if (marks > 80 && marks <= 90)
                {
                    scholarshipAmount = 0.3 * fees;
                }
                else if (marks > 90)
                {
                    scholarshipAmount = 0.5 * fees;
                }

                Console.WriteLine("Scholarship amount: " + scholarshipAmount);
            }

            static void Main(string[] args)
            {
                Console.Write("Enter marks: ");
                int marks = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter fees: ");
                int fees = Convert.ToInt32(Console.ReadLine());

                Merit(marks, fees);

                Console.ReadLine();
            }
        }
}

