using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            product.ProductName = "Halı";
            Console.WriteLine(product.ProductName + " Sepetinize Eklendi");

            
        }
    }
}
