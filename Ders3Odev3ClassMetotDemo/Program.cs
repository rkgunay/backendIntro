using System;

namespace Ders3Odev3ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Ali";
            customer1.Surname = "Veli";
            customer1.Birthplace = "Giresun";

            Customer customer2 = new Customer();
            customer2.Name = "Ahmet";
            customer2.Surname = "Ziyagilleroğulları";
            customer2.Birthplace = "Rize";

            Customer customer3 = new Customer();
            customer3.Name = "Rıdvan";
            customer3.Surname = "Günay";
            customer3.Birthplace = "Giresun";


            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            CustomerManager customerManager = new CustomerManager();

            foreach (var customer in customers)
            {
                
                customerManager.Add(customer);
                customerManager.Delete(customer);
                customerManager.Update(customer);
            }
        }
    }
}
