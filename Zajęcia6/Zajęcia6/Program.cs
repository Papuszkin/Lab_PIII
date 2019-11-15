using System;

namespace Zajęcia6
{
    class Program
    {
        static void OpiszSamochod(Samochod auto)
        {
            Console.WriteLine("[" + auto.VIN + "] " + auto.Model + ": " + auto.Przebieg + "km Ilosc drzwi:" + auto.IloscDrzwi + " Waga:" + auto.Waga + "kg");
        }

        static void OpiszStrone(Strona strona)
        {
            Console.WriteLine();
            Console.WriteLine("Serwer: ");
            Console.WriteLine("CPU: " + strona.SerwerStrony.CPU + 
                "GHz Łącze: " + strona.SerwerStrony.Lacze + 
                "Mbs  RAM: " + strona.SerwerStrony.RAM + "MB");

            Console.WriteLine("Domena:");
            Console.WriteLine("Nazwa: " + strona.DomenaStrony.nazwa +
                " Ważne do: " + strona.DomenaStrony.Waznosc.ToString("yyyy-MM-dd") +
                " Technologia: " + strona.DomenaStrony.technologia);
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


            // Ćwiczenie_______________

            // Treść:
            // Stworzenie klas i zabezpieczenie ich na podstawie schematu poniżej
            // Strona internetowa
            //  Serwer
            //   Szybkosc procesora
            //   Lacze
            //   Ram
            //  Domena
            //   Nazwa
            //   Waznosc : DateTime
            //   Technologia (PHP, Angular, HTML5)

            // 

            Strona mojastrona = new Strona(new Serwer(3.12, 100, 2048), new Domena("wp.pl", new DateTime(2020, 12, 12), "HTML5"));
            OpiszStrone(mojastrona);

            mojastrona.DomenaStrony.ZmienWaznosc(new DateTime(2019, 11, 10));
            mojastrona.DomenaStrony.ZmienWaznosc(new DateTime(2022, 01, 20));
            OpiszStrone(mojastrona);

        }
    }
}
