using System;

namespace Ders4Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenci = new MyDictionary<int, string>();
            ogrenci.Add(1, "Ömer");
            Console.WriteLine(ogrenci.Get(1));
            ogrenci.Add(2, "Rıdvan");
            Console.WriteLine(ogrenci.Get(2));

            ogrenci.Add(2, "Ömer");
            Console.WriteLine(ogrenci.Get(2));

            ogrenci.Add(3, "Ayça");
            Console.WriteLine(ogrenci.Get(3));

        }
    }
}
