using System;

namespace Zajęcia10
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Extenstion
            /*
            // Rozszerzenie int
            Console.Write("Podaj liczbe: ");
            int liczba = Convert.ToInt32(Console.ReadLine());

            (int wynik, int reszta) = liczba.Podziel(3);
            Console.WriteLine($"{liczba}/3={wynik} reszta {reszta}");
            Console.WriteLine();

            // Rozszerzenie string
            string text = "Ala ma kota a kot ma ale";
            Console.Write("Podaj znak: ");
            char znak = Convert.ToChar(Console.ReadLine());
            Console.Write("Wielkość znaków ma znaczenie (1/0): ");
            int wielkoscWazna = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"W ciagu \"{text}\" wystepuje {text.IleZnakow(znak, wielkoscWazna)} znaków \"{znak}\"");
            */
            #endregion

            Reklama reklama = new Reklama("Kup teraz", TypOsoby.Dziecko | TypOsoby.Mlodziez | TypOsoby.Starszy, Zainteresowania.Gaming);
            reklama.Test();
        }
    }
}
