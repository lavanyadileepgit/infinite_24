using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{

    using System;

    class Customer
    {
        private int customerId;
        private string name;
        private int age;
        private string phone;
        private string city;

        public Customer()
        {
        }

        public Customer(int customerId, string name, int age, string phone, string city)
        {
            this.customerId = customerId;
            this.name = name;
            this.age = age;
            this.phone = phone;
            this.city = city;
        }

        public void DisplayCustomer()
        {
            Console.WriteLine($"Customer ID: {customerId}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"City: {city}");
            Console.WriteLine();
        }

        ~Customer()
        {
            Console.WriteLine($"Customer {name} with ID {customerId} is being destroyed.");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of customers: ");
            int numCustomers = Convert.ToInt32(Console.ReadLine());

            Customer[] customers = new Customer[numCustomers];

            for (int i = 0; i < numCustomers; i++)
            {
                Console.WriteLine($"Enter details for Customer {i + 1}:");
                Console.Write("Customer ID: ");
                int customerId = Convert.ToInt32(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Phone: ");
                string phone = Console.ReadLine();

                Console.Write("City: ");
                string city = Console.ReadLine();

                customers[i] = new Customer(customerId, name, age, phone, city);
            }

            Console.WriteLine("\nCustomer Details:");
            foreach (var customer in customers)
            {
                customer.DisplayCustomer();
            }
            Console.Read();
        }
    }


}
