using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Engin";
            customer1.LastName = "Demiroğ";
            customer1.IdentityNo = "2222222222";

            CoorporateCustomer customer2 = new CoorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "23456";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CoorporateCustomer();

            CustomerManager customerManager = new CustomerManager();

            // no problem for both individual class and coorporate class.
            customerManager.Add(customer1);
            customerManager.Add(customer2);


            // Gerçek - Tüzel Müşteri
            //SOLID -> L 

        }

    }
}
