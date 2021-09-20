using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //we use interface for this matter. 
    //if a class wants to use this class. They have to contain the methods below. In our case, "Calculate()" etc. 
    interface ICreditManager
    {
        void Calculate();
        void DoSomething();
    }
}
