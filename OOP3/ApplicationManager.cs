using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class ApplicationManager
    {
        //her degeri alabilir
        //Method Injection ------herhangi bir creditmanagerialır----herhangi bi loglayıcı alabilecek
        public void Apply(ICreditManager creditManager,ILoggerService loggerService)
        {
            creditManager.Calculate();

            loggerService.Log();
        }

        //herhangi adette gelebilir
        public void CreditInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
