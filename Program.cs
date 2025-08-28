///"بسم الله الرحمن الرحيم"
///" Supermarket Management"...
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Project_2
{
    public class Product
    {
        public string Name;
        public string Category;
        public double Quantity;
        public DateTime ProductionDate;
        public DateTime ExpiryDate;

        //Constructor
        public Product(string name, string category, double quantity, DateTime productiondate, DateTime expirydate)
        {
            this.Name = name;
            this.Category = category;
            this.Quantity = quantity;
            this.ProductionDate = productiondate;
            this.ExpiryDate = expirydate;
        }

        //Method to display product details
        public void Display()
        {
            Console.WriteLine($"Product: {Name}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Production Date: {ProductionDate.ToShortDateString()}");
            Console.WriteLine($"Expiry Date: {ExpiryDate.ToShortDateString()}");//عملناهاshort string  عشان متبعش الوقت يعني تطبع التاريخ بس

        }
        public static void BasicProducts()
        {
            List<Product> products = new List<Product>();
            Product P1 = new Product("Milk", "Dairy", 20, new DateTime(2025, 8, 1), new DateTime(2025, 8, 30));
            Product P2 = new Product("Bread", "Bakery", 50, new DateTime(2025, 8, 10), new DateTime(2025, 8, 25));
            Product P3 = new Product("Water", "Aquadelta", 80, new DateTime(2025, 7, 10), new DateTime(2026, 7, 10));
            products.Add(P1);
            products.Add(P2);
            products.Add(P3);
            P1.Display();
            P2.Display();   
            P3.Display();

        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
             Product.BasicProducts();
        }
    }   
}