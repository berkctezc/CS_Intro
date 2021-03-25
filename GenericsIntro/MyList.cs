using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        //constructor
        public MyList()
        {
            items = new T[0];
        }
        
        public void Add(T item)
        {
            //referans kaybolmasın diye gecici bi diziye teslim ettik
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                //tempden gerçek listemize geri doldurma işlemleri
                items[i] = tempArray[i];
            }
            //eklemek istedigimiz veriyi listemizin sonuna ekledik
            items[items.Length - 1] = item;

        }
    }
}
