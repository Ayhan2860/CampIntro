using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 550.45;
            product1.UnitsInStock = 22;


            Product product2 = new Product() { Id = 2, CategoryId = 4, ProductName = "Kalem", UnitPrice = 3, UnitsInStock = 40 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product2.ProductName);
        }
    }
}
