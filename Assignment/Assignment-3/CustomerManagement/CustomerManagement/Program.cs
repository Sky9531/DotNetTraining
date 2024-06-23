using System;

namespace CustomerManagement
{
    public class Customer
    {
        private static int count = 0;

        public int CustomerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }

        public Customer()
        {
            CustomerId = ++count;
        }

        public Customer(string name, int age, string phone, string city)
        {
            CustomerId = ++count;
            Name = name;
            Age = age;
            Phone = phone;
            City = city;
        }

        public static void DisplayCustomer()
        {
            Console.WriteLine($"Total Customers: {count}");
        }

        ~Customer()
        {
            count--;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Alice", 25, "1234567890", "New York");
            Customer customer2 = new Customer("Bob", 30, "9876543210", "Los Angeles");

            Customer.DisplayCustomer();
            Console.ReadLine();
        }
    }
}
