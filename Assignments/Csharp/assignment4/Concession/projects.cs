using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concession;

namespace Concession
{
    class projects
    {
        public class TicketConcession
        {
            public string CalculateConcession(int age)
            {
                const int TotalFare = 500;
                return age <= 5 ? $"Little Champs - Free Ticket, Name: {Name}, Age: {age}"
                                : age > 60 ? $"Senior Citizen, Name: {Name}, Age: {age}, Fare: {(int)(TotalFare * 0.7)}"
                                           : $"Ticket Booked, Name: {Name}, Age: {age}, Fare: {TotalFare}";
            }

            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}

