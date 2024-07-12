﻿using System;

namespace SaleManagement
{
    public class Saledetails
    {
        private int salesNo;
        private int productNo;
        private decimal price;
        private DateTime dateOfSale;
        private int qty;
        private decimal totalAmount;

        public Saledetails(int salesNo, int productNo, decimal price, int qty, DateTime dateOfSale)
        {
            this.salesNo = salesNo;
            this.productNo = productNo;
            this.price = price;
            this.qty = qty;
            this.dateOfSale = dateOfSale;
            this.totalAmount = qty * price;
        }

        public void Sales(int qty, decimal price)
        {
            this.qty = qty;
            this.price = price;
            this.totalAmount = qty * price;
        }

        public void ShowData()
        {
            Console.WriteLine($"Sales No: {salesNo}");
            Console.WriteLine($"Product No: {productNo}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine($"Quantity: {qty}");
            Console.WriteLine($"Date of Sale: {dateOfSale}");
            Console.WriteLine($"Total Amount: {totalAmount}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Saledetails sale = new Saledetails(1001, 2001, 50.0m, 10, DateTime.Now);
            sale.ShowData();
            Console.ReadLine();
        }
    }
}
