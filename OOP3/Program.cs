using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {

            ICreditManager financeCreditManager = new FinanceCreditManager();
            //financeCreditManager.Calculate();
            ICreditManager transportCreditManager = new TransportCreditManager();
            //transportCreditManager.Calculate();
            ICreditManager mortageCreditManager = new MortageCreditManager();
            //mortageCreditManager.Calculate();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            List<ILoggerService> loggers = new List<ILoggerService>() { databaseLoggerService, fileLoggerService, new SmsLoggerService() };




            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeAnApplication(new ArtisanCredit(),loggers);

            List<ICreditManager> credits = new List<ICreditManager>() { transportCreditManager, mortageCreditManager };
            //applicationManager.MakeCreditPrenotification(credits);

          

           

           

           



        }
    }
}
