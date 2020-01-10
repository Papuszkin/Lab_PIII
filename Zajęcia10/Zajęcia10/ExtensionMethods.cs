using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Zajęcia10
{
    static public class ExtensionMethods
    {
        // Obliczanie wyniku dzielenia i reszty z dzielenia przez podana liczbe
        public static (int,int) Podziel(this int dzielna, int dzielnik)
        {
            return (dzielna / dzielnik, dzielna % dzielnik);
        }

        // Zliczanie ilości występowania podanego znaku w stringu
        public static int IleZnakow(this string ciag, char znak)
        {
            int ile = 0;
            for (int i = 0; i < ciag.Length; i++)
            {
                if (ciag[i] == znak)
                {
                    ile++;
                }
            }
            return ile;
        }

        // Sprawdzanie ilości znaków bez względu na wielkosc znaku
        public static int IleZnakow(this string ciag, char znak, int caseSensitive = 1)
        {
            if (caseSensitive == 1) 
            {
                return IleZnakow(ciag, znak);
            }
            else
            {
                return IleZnakow(ciag.ToLower(), char.ToLower(znak));
            }
        }

        // Zliczanie liczby elementów w Enum
        public static int SumaTypowOsob(this TypOsoby typ)
        {
            int suma = 0;
            foreach (var item in Enum.GetValues(typeof(TypOsoby)))
            {
                suma += (int)item;
            }
            return suma;
        }
    }
}
