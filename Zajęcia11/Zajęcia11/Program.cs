using System;

namespace Zajęcia11
{
    class Program
    {
        /* Pattern Matching (funkcja)
        static double ObliczCeneBiletu(object pasazer)
        {
            // Werjsa 1
            if (pasazer is Dziecko dziecko)
            {
                Console.WriteLine($"To jest dziecko, ma zniżkę: {dziecko.Znizka}");
            }
            else if (pasazer is OsobaStarsza oStarsz)
            {
                Console.Write("To jest osoba starsza. ");
                if (oStarsz.ZwolnienieZOplaty)
                {
                    Console.WriteLine("Ma darmowe przejazdy.");
                }
            }

            // Wersja 2
            switch (pasazer)
            {
                case Dziecko d:
                    Console.WriteLine($"To jest dziecko, ma zniżkę: {d.Znizka}");
                    break;
                case OsobaStarsza os when os.ZwolnienieZOplaty:
                    Console.WriteLine("To jest osoba starsza. Ma darmowe przejazdy.");
                    break;
                case OsobaStarsza _:
                    Console.Write("To jest osoba starsza.");
                    break;
                case Rencista r1 when r1.BezTerminowa == true:
                    Console.WriteLine($"Rencista ma bezterminowa zniżkę {r1.Znizka}");
                    break;
                case Rencista r2 when r2.DataWażności > DateTime.Now:
                    Console.WriteLine($"Rencista ma zniżke {r2.Znizka} ważna do {r2.DataWażności.ToShortDateString()}");
                    break;
                case Rencista _:
                    Console.WriteLine($"Rencista nie ma ważnej zniżki");
                    break;
                case null:
                    Console.WriteLine("Nie wiem co to");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
            return 0;
        }
        */

        static void Main(string[] args)
        {
            /* Pattern matching (wykonywanie)
            var pasazer = new ZwyklyPasazer();
            var dziecko = new Dziecko() { Znizka = 0.5 };
            var emeryt = new OsobaStarsza() { ZwolnienieZOplaty = true };
            var rencista = new Rencista(new DateTime(2020, 02, 01), 0.2);
            var rencista_bez = new Rencista(true, 0.5);
            var rencista_stara = new Rencista(new DateTime(2019, 12, 03), 0.2);

            Console.WriteLine("Zwykły pasazer:");
            ObliczCeneBiletu(pasazer);
            Console.WriteLine("\nDziecko:");
            ObliczCeneBiletu(dziecko);
            Console.WriteLine("\nEmeryt:");
            ObliczCeneBiletu(emeryt);
            Console.WriteLine("\n\"Pasazer\":");
            ObliczCeneBiletu("Pasazer");
            Console.WriteLine("\nRencista:");
            ObliczCeneBiletu(rencista);
            Console.WriteLine("\nRencista z bezterminowa zniżką:");
            ObliczCeneBiletu(rencista_bez);
            Console.WriteLine("\nRencista ze starą zniżką:");
            ObliczCeneBiletu(rencista_stara);
            Console.WriteLine("\nNULL:");
            ObliczCeneBiletu(null);
            */

            var osoba = new OsobaStarsza()
            {
                NrLegitymacji = "1234567890",
                ZwolnienieZOplaty = true,
                DataUrodzenia = DateTime.Now.AddYears(-70),
                AdresZdjecia = "./images/photos/1234567890.jpg"
            };

            /* Dekonstrukcja tupli
            (string legitka, bool znizka, DateTime dataUt, string fotka) = osoba.ZwrocWszystkieDane();
            Console.WriteLine(legitka);

            var (legitymacja, obnizka, dataUrod, zdjecieRencisty) = osoba.ZwrocWszystkieDane();
            Console.WriteLine(legitymacja);

            var temp = osoba.ZwrocWszystkieDane();
            Console.WriteLine(temp.nrLegitymacji);

            (_, bool obz, DateTime dU, string foto) = osoba.ZwrocWszystkieDane();
            */

            // Dekonstruktory
            var (nrLegitymacji, zwolnienie, dataUr, zdjecie) = osoba;
            var (nrLegitki, fotka) = osoba;


            var dzieciak = new Dziecko()
            {
                DataUrodzenia = new DateTime(2010, 05, 02),
            };
            var (szkola, dataUro) = dzieciak;
            Console.WriteLine($"Szkoła: {szkola}, data urodzenia: {dataUro.ToShortDateString()}");
        }
    }
}
