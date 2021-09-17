using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string categoryLabel = "Category";
            string loggedInCheckSimilationTrue = "User Settings Button";
            string loggedInCheckSimilationFalse = "Login Button";
            int studentNumber = 32000;
            double interestRate = 1.42;
            double dolarYesterday = 6.59;
            double dolarToday = 6.62;
            string decreaseButton = "Show decrease button";
            string increaseButton = "Show increase button";
            string equalButton = "Show equal button";
            bool isLoggedIn = false;

            if (dolarYesterday > dolarToday)
            {
                Console.WriteLine(decreaseButton);
            }
            else if(dolarYesterday < dolarToday)
            {
                Console.WriteLine(increaseButton);
            }
            else
            {
                Console.WriteLine(equalButton);
            }

            if (isLoggedIn == true)
            {
                Console.WriteLine(loggedInCheckSimilationTrue);
            }
            else
            {
                Console.WriteLine(loggedInCheckSimilationFalse);
            }
            Console.WriteLine(categoryLabel);
        }
    }
}
