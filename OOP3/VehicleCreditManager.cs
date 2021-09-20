using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Vehicle Credit Payment Plan Calculated.");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
