using System;

namespace Zajęcia6
{
    class Program
    {
        static void OpiszSamochod(Samochod auto)
        {
            Console.WriteLine("[" + auto.VIN + "] " + auto.Model + ": " + auto.Przebieg + "km Ilosc drzwi:" + auto.IloscDrzwi + " Waga:" + auto.Waga + "kg");
        }

        static void Main(string[] args)
        {
            Samochod mojsamochod = new Samochod("Multipla", 100000, 4, 700);
            OpiszSamochod(mojsamochod);
            //mojsamochod.Waga = 2000;
            //mojsamochod.Przebieg = 300000;
            //OpiszSamochod(mojsamochod);

            Samochod s2 = new Samochod("Punto", 150000, 2, 800);
            s2.ZwiekszDystans(100);
            Samochod s3 = new Samochod("Maluch", 305000, 4, 600);
            OpiszSamochod(s2);
            OpiszSamochod(s3);
            Console.WriteLine("Wyprodukowano: " + Samochod.IloscModeli);
            Samochod s4 = new Samochod(4, 700);
            OpiszSamochod(s4);
            
        }
    }
}
