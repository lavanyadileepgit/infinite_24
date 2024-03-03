using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1_
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

        public void Credit(double amount)
        {
            this.balance += amount;
        }

        public void Debit(double amount)
        {
            if (amount <= this.balance)
            {
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("insufficient bal");
            }
        }

        public void UpdateBalance(char transactionType, double amount)
        {
            this.transactionType = transactionType;
            this.amount = amount;
            if (transactionType == 'D')
            {
                Credit(amount);
            }
            else if (transactionType == 'W')
            {
                Debit(amount);
            }
        }

        public void ShowData()
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

            Console.Write("Enter Transaction Type (D for Deposit, W for Withdrawal): ");
            char transactionType = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            account.UpdateBalance(transactionType, amount);

            account.ShowData();
            Console.Read();
        }
    }

}



