using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager(); // Interfaces can hold reference of the class which implement this interface.
            IKrediManager tasitKrediManager = new TasitKrediManager(); // Interfaces can hold reference of the class which implement this interface.
            IKrediManager konutKrediManager = new KonutKrediManager(); // Interfaces can hold reference of the class which implement this interface.
            ILoggerService databaseloggerService = new DatabaseLoggerService();
            FileLoggerService fileloggerService = new FileLoggerService();

            List<ILoggerService> logger = new List<ILoggerService>() {new DatabaseLoggerService(), new SMSLoggerService()};


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKredisiManager(), logger);

            List<IKrediManager> krediler = new List<IKrediManager>() {konutKrediManager, tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
