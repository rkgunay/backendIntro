using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager

    {
        //this is a bad way because now all the credit applications calculate mortgage credit. 
        // We will use dependency injection and use correct way. IMPORTANT POINT. 
        //public void Apply()
        //{
        //    MortgageCreditManager mortgageCreditManager= new MortgageCreditManager();
        //    mortgageCreditManager.Calculate();
        //}


        //This is much better.
        //Method injection
        public void Apply(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void CreditInfo(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }

    }
}
