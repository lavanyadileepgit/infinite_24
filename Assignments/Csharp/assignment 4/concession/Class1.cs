using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concession
{
    public class TicketConcession
        {
            public void CalculateConcession(int age, string name, int fare)
            {
                if (age <= 5)
                {
                    Console.WriteLine($"Little Champs - Free Ticket, Name: {name}, Age: {age}");
                }
                else if (age > 60)
                {
                    double discount = fare * 0.3;
                    int discountedFare = (int)fare - (int)discount;
                    Console.WriteLine($"Senior Citizen - Discounted Fare: {discountedFare}, Name: {name}, Age: {age}");
                }
                else
                {
                    Console.WriteLine($"Ticket Booked - Fare: {fare}, Name: {name}, Age: {age}");
                }
            }

            public static void Main(string[] args)
            {
                TicketConcession tc = new TicketConcession();
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());
                const int fare = 500;
                tc.CalculateConcession(age, name, fare);
                Console.Read();
            }
        }
    }

