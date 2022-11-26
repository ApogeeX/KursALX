using ShopApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApp
{
    public class ShoppingCartService
    {
        public static void Run()
        {
            var products = new List<Product>();
            var shoppingCart = new ShoppingCart();

            char choice = '1';
            while (choice != '0')
            {
                Console.WriteLine("Choose option: ");
                Console.WriteLine("1 - Add product to Products");
                Console.WriteLine("2 - Add product to cart");
                Console.WriteLine("3 - Show cart");
                Console.WriteLine("0 - End program");
                choice = Console.ReadKey().KeyChar;

                if (choice == '1')
                {
                    var product = new Product();
                    Console.WriteLine();
                    Console.Write("Enter name of product: ");
                    product.ProductName = Console.ReadLine();
                    Console.Write("Enter price: ");
                    product.Price = decimal.Parse(Console.ReadLine());
                    products.Add(product);
                    Console.WriteLine($"Product {product.ProductName} added to Products");
                }
                else if (choice == '2')
                {
                    ShowList(products);
                    shoppingCart.Products.Add(products[0]);
                }
                else if (choice == '3')
                {
                    Console.WriteLine(shoppingCart.GetPrice());
                }
                else
                {
                    Console.WriteLine("Ending program.");
                    choice = '0';
                }
            }
        }

        public static void ShowList(List<Product> list)
        {
            Console.WriteLine($"Number of elements: {list.Count}");
            foreach (Product item in list)
            {
                Console.WriteLine();
                Console.WriteLine($"{item.ProductName} {item.Price}");
            }
            Console.WriteLine();
        }
    }
}
