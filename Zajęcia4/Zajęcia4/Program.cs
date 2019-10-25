using System;

namespace Zajęcia4
{
    class Komputer
    {
        public double predkosc;
        public int ram;
        public double dysk;

        public void Opisz()
        {
            Console.WriteLine(predkosc + "GHz   Ram:" + ram + "GB   Dysk:" + dysk + "GB");
        }
    }
    class Program
    {
        // Kalkulator
        static string WczytajLiczbe(string licznik)
        {
            Console.WriteLine("Podaj liczbę " + licznik + ":");
            string tekst = Console.ReadLine();
            return tekst;
        }

        

        static void Main(string[] args)
        {
            

            string tekst1 = WczytajLiczbe("1");
            string tekst2 = WczytajLiczbe("2");
            Console.WriteLine("Wybierz operacje:");
            string operacja = Console.ReadLine();
            int liczba1 = Convert.ToInt32(tekst1);
            int liczba2 = Convert.ToInt32(tekst2);

            switch (operacja)
            {
                case "+":
                    Console.WriteLine(Kalkulator.Dodaj(tekst1, tekst2));
                    break;
                case "-":
                    Console.WriteLine(Kalkulator.Odejmij(liczba1, liczba2));
                    break;
                case "*":
                    Console.WriteLine(Kalkulator.Pomnoz(liczba1, liczba2));
                    break;
                case "/":
                    //double wynik = Podziel(liczba1, liczba2, out bool rezultat);
                    //if (rezultat)
                    //{
                    //    Console.WriteLine(wynik);
                    //}
                    //else
                    //{
                    //    Console.WriteLine("Nie dziel przez zero");
                    //}
                    try
                    {
                        Console.WriteLine(Kalkulator.PodzielZWyjatkiem(liczba1, liczba2));
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Nie dziel przez zero");
                        
                    }
                    
                    break;
                default:
                    break;
            }

            //Klasy
            Komputer komputer1 = new Komputer();
            komputer1.predkosc = 3.5;
            komputer1.ram = 64;
            komputer1.dysk = 1000;
            komputer1.Opisz();
        }
    }
}
