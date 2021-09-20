using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            // We created a generic list class. 
            // How did we do that. I will explain in the MyList class. 
            MyList<string> names = new MyList<string>();
            names.Add("Elif");
            Console.WriteLine(names.Length);
            names.Add("Engin");
            Console.WriteLine(names.Length);

            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            dictionary.Add(1, 1);

            foreach (var item in names.Items)
            {
                Console.WriteLine(item);
            }
        }


    }
}
