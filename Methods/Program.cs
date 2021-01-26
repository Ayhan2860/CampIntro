using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Fındık";
            product1.UnitPrice = 23.45;
            product1.Explanation = "Giresun Kalite Fındık ";

            Product product2 = new Product();
            product2.ProductName = "Karpuz";
            product2.UnitPrice = 5.45;
            product2.Explanation = "Diyarbakır Karpuzu";


            Product product3 = new Product();
            product3.ProductName = "Çemen";
            product3.UnitPrice = 12.23;
            product3.Explanation = "Meşhur Tokat Çemeni";


            Product[] products = new Product[] { product1, product2, product3 };

            foreach (Product product in products)
            {
                Console.WriteLine("Ürün Adı : " + product.ProductName);
                Console.WriteLine("Ürün Fiyatı : " + product.UnitPrice);
                Console.WriteLine("Açıklama : " + product.Explanation + "\n*********************" );
            }
            Console.WriteLine("\n***** Metotlar *******\n");

            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product3);


            basketManager.Add2("Zeytin", 15, "Bursa Gemlik");
            basketManager.Add2("Fıstık", 32, "Antep Fıstığı");

        }
    }
}
