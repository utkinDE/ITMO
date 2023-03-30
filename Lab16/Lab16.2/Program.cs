using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace Lab16._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Product.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);
            Product maxProduct = products[0];

            foreach (Product e in products)
            {
                if (e.Cost > maxProduct.Cost)
                {
                    maxProduct = e;
                }
            }

            Console.WriteLine($"{maxProduct.ProductCode} {maxProduct.Name} {maxProduct.Cost}");
            Console.ReadKey();
        }
    }
}