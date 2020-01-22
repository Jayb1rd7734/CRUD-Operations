using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    class Program
    {
        public static void Main(string[] args)
        {
            ProductRepo repo = new ProductRepo();

            //Create products.
            Console.WriteLine("Creating product.....");
            var newProduct = new Product { Name = "Nathans Product", Price = 19.99M, CategoryID = 2, OnSale = 0 };
            repo.CreateProduct(newProduct);
            Console.WriteLine("Product created!!");

            //UpdateProducts.
            Console.WriteLine("Updating product.....");
            var newInfo = new Product { ProductID = 944, StockLevel = 27 };
            repo.UpdateProduct(newInfo);
            Console.WriteLine("Product updated.");

            //Delete products
            Console.WriteLine("Deleting first product.......");
            repo.DeleteProduct(944);
            Console.WriteLine("Deleting second product.......");
            repo.DeleteProduct("Nathans Product");
            Console.WriteLine("Deleting third product.......");
            repo.DeleteProduct(946, "Nathans Product");
            Console.WriteLine("Finished.");
            Console.ReadKey(true);

            //Read products.
            List<Product> products = repo.GetProducts();

            foreach(var prod in products)
            {
                Console.WriteLine($"  {prod.ProductID}\t {prod.Name}\t ${prod.Price}\t {prod.StockLevel}");                
            }
            Console.ReadKey(true);
        }
    }
}
