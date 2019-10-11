using System;

namespace Zajecia2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  
            __________Sprawdzanie parzystości liczby__________
            
            Console.WriteLine("Podaj liczbę:");
            string odpowiedz = Console.ReadLine();
            int liczba;
            bool czyLiczba = int.TryParse(odpowiedz, out liczba);
            if (czyLiczba)
            {
                if (liczba % 2 == 0)
                {
                    Console.WriteLine("Liczba parzysta");
                }
                else
                {
                    Console.WriteLine("Liczba nieparzysta");
                }
            }
            else
            {
                Console.WriteLine("Nie podano liczby");
            }
            */

            /*
            __________Sprawdzanie parzystości liczby v2__________

            Console.WriteLine("Podaj liczbę:");
            string odpowiedz = Console.ReadLine();
            int liczba = Convert.ToInt32(odpowiedz);
            Console.WriteLine((liczba % 2 == 0) ? "Parzysta" : "Nieparzysta");
            */

            /*
            __________Liczenie wartości średniej__________

            double odleglosc = -1;
            double suma = 0;
            int licznik =  -1;
            while (odleglosc != 0)
            {
                string odlegloscText = Console.ReadLine();
                odleglosc = Convert.ToDouble(odlegloscText);
                suma += odleglosc;
                licznik++;
            }
            double wynik = suma / licznik;
            Console.WriteLine("Srednia: "+wynik);
            */

            /*
            __________Zliczanie elementów_________
            int licznik = 1;
            string linia = string.Empty;
            while (linia != "exit" && licznik != 2100)
            {
                linia = Console.ReadLine();
                Console.WriteLine(licznik++);
            }
            Console.WriteLine("Bye bye");
            */

            /*
            __________Zliczanie elementów v2__________
            int licznik = 0;
            int licznikA = 0;
            int licznikS = 0;
            int licznikD = 0;
            string linia = string.Empty;
            while (linia != "exit")
            {
                linia = Console.ReadLine();

                switch (linia)
                {
                    case "a":
                        Console.WriteLine("A: " + ++licznikA);
                        break;
                    case "s":
                        Console.WriteLine("S: " + ++licznikS);
                        break;
                    case "d":
                        Console.WriteLine("D: " + ++licznikD);
                        break;
                    default:
                        Console.WriteLine("Zły kod produktu");
                        break;
                }
            }
            licznik = licznikA + licznikD + licznikD;
            Console.WriteLine("Suma: "+licznik);
            Console.WriteLine("Bye bye");
            */
        }
    }
}
