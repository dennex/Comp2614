using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP2614HomeLab02
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[3];

            products[0] = new Product();
            products[0].Price = 69.99m;
            products[0].Description = "Green blouse";

            products[1] = new Product(5.95m, "Shampoo");
            products[2] = new Product { Price = 32m, Description = "Cat food (10kg)" };

            displayProducts(products);

            Console.Write("\nSelling product 1...\n");
            products[0].Sell();
            displayProducts(products);

            Console.Write("\nSelling product 2...\n");
            products[1].Sell();
            displayProducts(products);

            Console.Write("\nShipping product 2...\n");
            products[1].Ship();
            displayProducts(products);

            Console.WriteLine("Done...");
            Console.ReadLine();
        }

        private static void displayProducts(Product[] products)
        {
            foreach (Product product in products)
            {
                Console.WriteLine("{0}: {1} for {2:N2}"
                                  , product.ProductStatus.ToString()
                                  , product.Description
                                  , product.Price);
            }

            Console.WriteLine();
        }
    }
}
