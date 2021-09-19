using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Engin", "Ali", "Veli", "Rıdvan" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            //it's okay this far. 
            /* But I can't do this like this
             * 
             * names[4] = "Ahmet";
             * Console.WriteLine(names[4]);
             * 
             * Because It's out of boundry
             * 
             * I can't do names = new string[5]; 
             * Because that changes adress of names variables. Which means all of 
             * names[] values will be lost
             *  
             */

            //THAT'S WHY WE USE COLLECTIONS 

            List<string> names1 = new List<string> { "Ali", "Kübra", "Selin", "Ayşe" };
            Console.WriteLine(names1[0]);
            Console.WriteLine(names1[1]);
            Console.WriteLine(names1[2]);
            Console.WriteLine(names1[3]);
            names1.Add("Rıdvan");
            Console.WriteLine(names1[0]);
            Console.WriteLine(names1[4]);
        }
        




    }
}
