using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {    //encapsulation
        public void Add(Product product ) //Örneğin string türünde bir isim ver gibi düiün "string isim" 
        {
            Console.WriteLine(product.ProductName + "eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }



    }
}
