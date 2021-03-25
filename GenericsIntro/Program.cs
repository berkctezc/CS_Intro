using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            Console.WriteLine(names.Length);//0
            names.Add("Berkc");
            Console.WriteLine(names.Length);//1
            names.Add("Berkc");
            Console.WriteLine(names.Length);//2
            names.Add("Berkc");
            Console.WriteLine(names.Length);//3

            foreach (var name in names.Items)
            {
                Console.WriteLine(name);
            }
        }
    }
}
