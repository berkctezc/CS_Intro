using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalCreditManager = new PersonalCreditManager();
            //personalCreditManager.Calculate();

            ICreditManager carCreditManager = new CarCreditManager();
            //carCreditManager.Calculate();

            ICreditManager residenceCreditManager = new ResidenceCreditManager();
            //residenceCreditManager.Calculate();


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(residenceCreditManager, new DatabaseLoggerService());
            applicationManager.Apply(carCreditManager, new FileLoggerService());
            applicationManager.Apply(personalCreditManager,new DatabaseLoggerService());
            Console.WriteLine("------");

            List<ICreditManager> credits = new List<ICreditManager>() {personalCreditManager,carCreditManager,residenceCreditManager,
                new PersonalCreditManager()};//.....

            applicationManager.CreditInformation(credits);

        }
    }
}
