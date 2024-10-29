using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    using System;
    using System.Collections.Generic;


    public class Inventory<T>
    {

        private Dictionary<T, int> Stock { get; set; }


        private Dictionary<T, double> Prices { get; set; }


        public Inventory()
        {
            Stock = new Dictionary<T, int>();
            Prices = new Dictionary<T, double>();
        }


        public void AddProduct(T product, int quantity)
        {
            if (Stock.ContainsKey(product))
            {
                Stock[product] += quantity;
            }
            else
            {
                Stock[product] = quantity;
            }
        }


        public bool RemoveProduct(T product, int quantity)
        {
            if (Stock.ContainsKey(product) && Stock[product] >= quantity)
            {
                Stock[product] -= quantity;
                return true;
            }
            return false;
        }


        public int CheckStock(T product)
        {
            return Stock.ContainsKey(product) ? Stock[product] : 0;
        }


        public bool IsProductAvailable(T product, int quantity)
        {
            return Stock.ContainsKey(product) && Stock[product] >= quantity;
        }

        public List<T> GetAvailableProducts()
        {
            List<T> availableProducts = new List<T>();
            foreach (var item in Stock)
            {
                if (item.Value > 0)
                {
                    availableProducts.Add(item.Key);
                }
            }
            return availableProducts;
        }


        public void SetProductPrice(T product, double price)
        {
            Prices[product] = price;
        }

        public double GetProductPrice(T product)
        {
            return Prices.ContainsKey(product) ? Prices[product] : 0.0;
        }
    }


    public class ElectronicProduct
    {

        public string ProductName { get; }
        public double Price { get; }


        public ElectronicProduct(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }


        public override string ToString()
        {
            return $"ElectronicProduct{{productName=\"{ProductName}\", price={Price}}}";
        }
    }

    public class ClothingProduct
    {

        public string ProductName { get; }
        public double Price { get; }


        public ClothingProduct(string productName, double price)
        {
            ProductName = productName;
            Price = price;
        }


        public override string ToString()
        {
            return $"ClothingProduct{{productName=\"{ProductName}\", price={Price}}}";
        }
    }

    class Quetion8
    {
        static void Main()
        {

            Inventory<ElectronicProduct> electronicInventory = new Inventory<ElectronicProduct>();


            Inventory<ClothingProduct> clothingInventory = new Inventory<ClothingProduct>();


            ElectronicProduct phone = new ElectronicProduct("Smartphone", 500.0);
            ElectronicProduct laptop = new ElectronicProduct("Laptop", 1000.0);


            ClothingProduct shirt = new ClothingProduct("T-Shirt", 20.0);
            ClothingProduct jeans = new ClothingProduct("Jeans", 40.0);


            electronicInventory.AddProduct(phone, 50);
            electronicInventory.AddProduct(laptop, 30);


            clothingInventory.AddProduct(shirt, 100);
            clothingInventory.AddProduct(jeans, 80);


            electronicInventory.SetProductPrice(phone, 500.0);
            electronicInventory.SetProductPrice(laptop, 1000.0);
            clothingInventory.SetProductPrice(shirt, 20.0);
            clothingInventory.SetProductPrice(jeans, 40.0);


            Console.WriteLine(string.Join(", ", electronicInventory.GetAvailableProducts()));
            Console.WriteLine(string.Join(", ", clothingInventory.GetAvailableProducts()));


            Console.WriteLine(electronicInventory.IsProductAvailable(phone, 20));


            bool removed = electronicInventory.RemoveProduct(phone, 10);
            Console.WriteLine(removed);
            Console.WriteLine(electronicInventory.CheckStock(phone));
        }
    }


}
