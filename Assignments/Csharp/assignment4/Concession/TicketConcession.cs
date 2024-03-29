﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concession
{
    public class TicketConcession
    {
        public static void Query1()
        {
            Console.Write("Enter a list of numbers (comma-separated): ");
            string input = Console.ReadLine();

            List<int> numbers = input.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var query = numbers.Select(n => new { Number = n, Square = n * n })
                               .Where(x => x.Square > 20)
                               .Select(x => x.Square);

            foreach (var item in query)
            {
            }
        }
    }
}

