using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class LittleBusinessOwnerCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Little Business Owner Credit Calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
