using System;
using System.Collections.Generic;
using System.Text;

namespace Math
{
    class FourCalculations
    {
        public void Add(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine("Sonuç: " + result);
        }
        public void Substract(int number1, int number2)
        {
            int result = number1 - number2;
            Console.WriteLine("Sonuç: " + result);
        }
        public void Divide(int number1, int number2) 
        {
            double result = number1 / number2;
            Console.WriteLine("Sonuç: " + result);
        }
        public void Multiply(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine("Sonuç: " + result);
        }
    }
}
