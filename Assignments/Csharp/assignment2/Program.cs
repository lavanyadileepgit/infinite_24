using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Accounts
    {
        private int accountNo;
        private string customerName;
        private string accountType;
        private char transactionType;
        private double amount;
        private double balance;

        public Accounts(int accountNo, string customerName, string accountType)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.balance = 0.0;
        }

        public void credit(double amount)
        {
            this.balance += amount;
        }

        public void debit(double amount)
        {
            if (amount <= this.balance)
            {
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("no bal");
            }
        }

        public void updatebal(char transactionType, double amount)
        {
            this.transactionType = transactionType;
            this.amount = amount;
            if (transactionType == 'D')
            {
                credit(amount);
            }
            else if (transactionType == 'W')
            {
                debit(amount);
            }
        }

        public void data()
        {
            Console.WriteLine($"Account No: {accountNo}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Balance: {balance}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("enter Acc No: ");
            int accountNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter Custr name: ");
            string customerName = Console.ReadLine();

            Console.Write("enter Acc Type: ");
            string accountType = Console.ReadLine();

            Accounts account = new Accounts(accountNo, customerName, accountType);

            Console.Write("Enter Trans type (D for Deposit, W for Withdrawal): ");
            char transactionType = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter Amt: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            account.updatebal(transactionType, amount);

            account.data();
            Console.Read();
        }
    }
}
