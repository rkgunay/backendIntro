using System;
using System.Collections.Generic;
using System.Text;

namespace Ders3Odev3ClassMetotDemo
{
    class CustomerManager
    {
        public  void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi: " + customer.Name + " " + customer.Surname);
        }
        public  void Delete(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi: " + customer.Name + " " + customer.Surname);
        }
        public  void Update(Customer customer)
        {
            Console.WriteLine("Müşteri Bilgileri Güncellendi: " + customer.Name + " " + customer.Surname +"\n");
        }
    }
}
