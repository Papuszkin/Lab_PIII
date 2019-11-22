using System;
using System.Collections.Generic;
using System.Text;

namespace Zajęcia7_Kolokwium
{
    class EBook
    {
        public String Autor { get; private set; }
        public String Tytul { get; private set; }
        public DateTime DataWydania { get; private set; }
        public DateTime DataOstatniegoZakupu { get; set; }
        public double CenaStandardowa { get; set; }
        public double Obnizka { get; set; }
        public double AktualnaCena { get; set; }

        public EBook(string autor, string tytul, DateTime dataWydania, DateTime dataOstatniegoZakupu, double cenaStandardowa, double obnizka)
        {
            Autor = autor;
            Tytul = tytul;
            DataWydania = dataWydania;
            DataOstatniegoZakupu = dataOstatniegoZakupu;
            if (cenaStandardowa < 0)
            {
                Console.WriteLine("Zła cena standardowa");
                CenaStandardowa = 0;
            }
            else
            {
                CenaStandardowa = cenaStandardowa;
            }
            if ((CenaStandardowa * ((100 - obnizka) / 100) < 0))
            {
                Console.WriteLine("Za duza obnizka");
                Obnizka = 0;
            }
            else
            {
                Obnizka = obnizka;
            }
            AktualnaCena = CenaStandardowa * ((100 - obnizka) / 100);
        }

        public void Zakup(DateTime NowaData)
        {
            if (DataOstatniegoZakupu > NowaData)
            {
                Console.WriteLine("Nie można podać starszej daty");
            }
            else
            {
                DataOstatniegoZakupu = NowaData;
            }
        }


    }
}
