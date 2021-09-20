using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //We can use Interface to keep the adress of implemented classes. 
            ICreditManager expanseCreditManager = new ExpanseCreditManager();
            ICreditManager mortgageCreditManager = new MortgageCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager littleBusinessOwnerCreditManager = new LittleBusinessOwnerCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService smsLoggerService = new SMSLoggerService();

            List<ILoggerService> loggerServices = new List<ILoggerService>() { databaseLoggerService, smsLoggerService };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(littleBusinessOwnerCreditManager, loggerServices );

            //List<ICreditManager> credits = new List<ICreditManager>() { expanseCreditManager, mortgageCreditManager, vehicleCreditManager};
            //applicationManager.CreditInfo(credits);

        }
    }

}
