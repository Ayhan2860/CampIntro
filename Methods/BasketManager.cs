using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " - Sepete Eklendi");
        }

        public void Add2(string ProductName, int UnitPrice, string Explanation)
        {
            Console.WriteLine(ProductName + " - Sepete Eklendi");
        }
    }
}
