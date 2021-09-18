using System;

namespace Methods
{
    class Program
    {
        
        static void Main(string[] args)
        {

            String newLine = "\n";

            Product product1 = new Product();
            product1.Name = "Elma";
            product1.Price = 15;
            product1.Definition = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 80;
            product2.Definition = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };


            //type safe
            foreach (var product in products)
            {
                Console.WriteLine(product.Name + newLine + product.Price + newLine + product.Definition +
                    newLine + "-------------------");
            }

            Console.WriteLine(newLine + "-----------Methodlar---------- " + newLine);


            // Encapsulation -- We use add function by using Product class. We do not use it 
            // like add(productName, productDefinition, productPrice); because if we add a new property
            // to product like stockCount, then we would have to change all add() functions like
            // add(productName, productDefinition, productPrice, stockCount). Which would be very
            // hard. So we use encapsulation which means we use our functions like add(product1) 
            // product1 is a member of Product class. If we want to add stockCount property, we go to 
            // Product class and add that property. After that we go to CartManager and update our function. 
            // But thanks to Encapsulation, we dont need to change add function's parameters. we still use a 
            // class as a parameter. not a property.



            CartManager cartManager = new CartManager();
            cartManager.Add(product1);
            cartManager.Add(product2);


        }
    }
}


// Don't Repeat Yourself Princible --- Why am i noting this. I don't know. I like the way it sounds. 