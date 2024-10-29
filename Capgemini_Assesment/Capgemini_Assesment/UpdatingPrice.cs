using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capgemini_Assesment
{
    using System;

    public class UpdatingPrice
    {
        public string UpdatePrice(string[] details, int id, double amount)
        {
            for (int i = 0; i < details.Length; i++)
            {
                string[] productParts = details[i].Split(':');
                int productId = int.Parse(productParts[0]);
                if (productId == id)
                {
                    productParts[2] = amount.ToString();
                    return productParts[1] + " " + productParts[2];
                }
            }
            return string.Empty;
        }

        public static void Main(string[] args)
        {
            UpdatingPrice up = new UpdatingPrice();
            Console.WriteLine("Enter the number of products:");
            int numProduct = Convert.ToInt32(Console.ReadLine()); // Changed ToInt to ToInt32
            Console.WriteLine("Enter the product details (format: id:name:price):");
            string[] productDetails = new string[numProduct];

            for (int i = 0; i < numProduct; i++)
            {
                productDetails[i] = Console.ReadLine();
            }

            Console.WriteLine("Enter the product id:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the amount to update:");
            double amount = double.Parse(Console.ReadLine());

            string result = up.UpdatePrice(productDetails, id, amount);
            if (string.IsNullOrEmpty(result))
            {
                Console.WriteLine("Invalid id");
            }
            else
            {
                Console.WriteLine(result);
            }
        }
    }

}
