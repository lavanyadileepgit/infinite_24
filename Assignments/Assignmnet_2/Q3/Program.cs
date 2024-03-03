using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{

    class SaleDetails
    {
        private int salesNo;
        private int productNo;
        private double price;
        private DateTime dateOfSale;
        private int qty;
        private double totalAmount;

        public SaleDetails(int salesNo, int productNo, double price, DateTime dateOfSale, int qty)
        {
            this.salesNo = salesNo;
            this.productNo = productNo;
            this.price = price;
            this.dateOfSale = dateOfSale;
            this.qty = qty;
            Sales();
        }

        private void Sales()
        {
            totalAmount = qty * price;
        }

        public void ShowData()
        {
            Console.WriteLine($"Sales No: {salesNo}");
            Console.WriteLine($"Product No: {productNo}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Date of Sale: {dateOfSale}");
            Console.WriteLine($"Qty: {qty}");
            Console.WriteLine($"Total Amount: {totalAmount}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter Sales Number: ");
            int salesNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Number: ");
            int productNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Date of Sale (yyyy-MM-dd): ");
            DateTime dateOfSale = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", " ");

            Console.Write("Enter Quantity: ");
            int qty = Convert.ToInt32(Console.ReadLine());

            SaleDetails sale = new SaleDetails(salesNo, productNo, price, dateOfSale, qty);

            sale.ShowData();
            Console.Read();
        }
    }

}
