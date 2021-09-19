using System;

namespace Ders3Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Calculations calculations = new Calculations();
            calculations.Add(a, b);
            Console.WriteLine(a);

            //Yukarıdaki kodlarda 12.satırdaki işlem konsola 50 yazdırır. Çünkü fonksiyonun içinde 
            //a değerine 30 verdik. b değeri aynı kaldı(20). toplamı 50 oldu. 
            //13.satırdaki değer de 10 değerini verdi. Fonksiyonun içinde 30 dediğimiz için değişmedi. 
            // fonksiyonu çağırırken fonksiyon, a değişkeninin değerini ilk parametreye atadı. Ve sonra
            // o parametreye 30 değerini atadı. a değişkenine dokunmadı. 

            //eğer a değişkenin de değişmesini isteseydik fonksiyonu Add(ref int a, int b) olarak tanımlardık.
            // Çağırıken de Add(ref int a, b) olarak çağırırdık. Böylece a değeri, fonksiyonun ilk parametresi
            // ile bağlanmış oldu. Bu şekilde çalıştırsaydık 13. satırdaki değer 30 olurdu. 
            // out da aynı fakat bunu kullanırken a = 10 dememize gerek yok 9.satırda. 
            // direkt int a; olarak tanımlayabilirdik. bir değer olmazdı. 
        }

        public class Calculations
        {
            public void Add(int a, int b)
            {
                a = 30;
                Console.WriteLine(a+b);
            }
        }
    }
}
