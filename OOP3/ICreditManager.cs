using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //Interfaceler birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız
    interface ICreditManager
    {
        //bu metotları bu interfaceden inherit olan classlar doldurmakla yükümlüdür
        void Calculate();

        void DoSomething();
    }
}
