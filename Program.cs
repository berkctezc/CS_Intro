using System;

namespace CS_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            void Intro()
            {
                //type safety
                //type - alias - value/data
                string kategoriEtiketi = "Kategori";
                Console.WriteLine(kategoriEtiketi);

                int ogrenciSayisi = 32000;
                double faizOrani = 1.45;

                bool girisYapildiMi = false;

                double dolarDun = 7.35;
                double dolarBugun = 7.45;

                if (girisYapildiMi == true)
                {
                    Console.WriteLine("giris basarili");
                }
                else
                {
                    Console.WriteLine("giris yapilmamis");
                }

                if (dolarBugun < dolarDun)
                {
                    Console.WriteLine("azalis butonu");
                }
                else
                {
                    Console.WriteLine("artis butonu");
                }
            }
            void Donguler()
            {
                for (int i = 1; i < 5; i++)
                {
                    Console.WriteLine(i);
                }


                //array - dizi
                string[] kurslar = new string[] { "A", "B", "C", "D", "E" };
                Console.WriteLine(kurslar.Length + " harf var!");

                Console.WriteLine("for array");

                for (int i = 0; i < kurslar.Length; i++)
                {
                    Console.WriteLine(kurslar[i]);
                }

                Console.WriteLine("foreach array");
                foreach (string kurs in kurslar)
                {
                    Console.WriteLine(kurs);
                }

            }
            void Classlar()
            {
                Kurs kurs1 = new Kurs();
                kurs1.KursAdi = "A Kursu";
                kurs1.IzlenmeOrani = 5;
                kurs1.Egitmen = "B.C.";

                Kurs kurs2 = new Kurs();
                kurs2.KursAdi = "B Kursu";
                kurs2.IzlenmeOrani = 6;
                kurs2.Egitmen = "B.D.";

                Kurs kurs3 = new Kurs();
                kurs3.KursAdi = "C Kursu";
                kurs3.IzlenmeOrani = 12;
                kurs3.Egitmen = "B.T.";

                Console.WriteLine(kurs1.KursAdi + " " + kurs1.Egitmen);
                Console.WriteLine();

                Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

                foreach (var k in kurslar)
                {
                    Console.WriteLine(k.KursAdi + ":" + k.Egitmen);
                }



            }

            Console.WriteLine("--Intro--");
            Intro();
            Console.WriteLine("--Donguler--");
            Donguler();
            Console.WriteLine("--Classlar--");
            Classlar();


        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}

