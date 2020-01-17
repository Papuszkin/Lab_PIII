using System;
using System.Collections.Generic;
using System.Text;

namespace Zajęcia11
{
    class Dziecko
    {
        public double Znizka { get; set; }
        public DateTime DataUrodzenia { get; set; }
        //6 lat - 1klasa

        public void Deconstruct(out string szkola, out DateTime dataUr)
        {
            if (DateTime.Now.Year - DataUrodzenia.Year < 6)
            {
                szkola = "Za mlody";
            }
            else if (DateTime.Now.Year - DataUrodzenia.Year >= 6 && DateTime.Now.Year - DataUrodzenia.Year < 14)
            {
                szkola = "Podstawówka";
            }
            else if (DateTime.Now.Year - DataUrodzenia.Year >= 14 && DateTime.Now.Year - DataUrodzenia.Year < 17)
            {
                szkola = "Średnia";
            }
            else
            {
                szkola = "Wyższa";
            }
            dataUr = DataUrodzenia;
        }
    }
}
