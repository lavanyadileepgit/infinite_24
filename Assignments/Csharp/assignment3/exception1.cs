using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmnet3
{
    class exception1
        {
            static void Main(string[] args)
            {
                decimal balance = 100;

                while (true)
                {
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Check balance");
                    Console.WriteLine("4. Exit");

                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter deposit amount: ");
                            balance += Convert.ToDecimal(Console.ReadLine());
                            break;
                        case 2:
                            Console.Write("Enter withdrawal amount: ");
                            decimal amount = Convert.ToDecimal(Console.ReadLine());
                            if (amount > balance)
                            {
                                Console.WriteLine("Insufficient balance.");
                            }
                            else
                            {
                                balance -= amount;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Current balance: " + balance);
                            break;
                        case 4:
                            return;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
            }
        }
    }


