using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)

        {
            Console.WriteLine("Ürün eklendi : " + product.ProductName);
        }
        public void Update(Product product)
        {
            Console.WriteLine("Ürün güncellendi : " + product.ProductName);
        }

        /*------------------------------------------------*/ 

        public int Addition(int num1, int num2) {
            return num1 + num2;
        }// this returns a value. int value because we said int. 

        public void Addition2(int num1, int num2)
        {
            Console.WriteLine(num1+num2);
        }//void does something but doesn't return a value


        /*------------------------------------------------*/
    }
}

