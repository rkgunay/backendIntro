using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class CartManager
    {
        //naming convention
        public void Add(Product product)
        {
            Console.WriteLine("Sepete Eklendi. "  + product.Name);

        }
    }
}
