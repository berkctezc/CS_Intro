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
        public void Apply(ICreditManager creditManager)
        {
            creditManager.Calculate();
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
