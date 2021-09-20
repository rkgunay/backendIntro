using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ExpanseCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Expanse Credit Payment Plan Calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
