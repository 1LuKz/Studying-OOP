using System;
using ProductsStore.Entities;

namespace ProductsStore
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> product = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"\nProduct #{i} data");

                Console.Write("Common, used or imported (c/u/i)? ");
                char answer = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine());   

                if(answer == 'u' || answer == 'U')
                {
                    Console.Write("Manufacture date (dd/MM/yyyy): ");
                    DateTime manufacture = DateTime.Parse(Console.ReadLine());
                    product.Add(new UsedProduct (name, price, manufacture));
                }
                else if(answer == 'i' ||  answer == 'I')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    product.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                {
                    product.Add(new Product(name, price));
                }
            }

            Console.WriteLine("\nPrice tags: ");
            foreach(Product products in product)
            {
                Console.WriteLine(products.PriceTag());
            }
        }
    }
}