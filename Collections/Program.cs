using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Berkc", "Can", "Berkay" };
            int i=0;
            foreach (var a in names)
            {
                Console.WriteLine(i+":"+a);
                i += 1;
            }
            i = 0;
            names = new string[4];
            names[3] = "Tezc";
            foreach (var a in names)
            {
                Console.WriteLine(i + ":" + a);
                i += 1;
            }
            //liste boşaltılmış oldu...

            List<string> names2 = new List<string> { "Berk", "Can", "Berkay" };
            names2.Add("Tezc");
            Console.WriteLine(names2[1]);
            foreach (var a in names2)
            {
                Console.WriteLine(a);
            }
        }
    }
}
