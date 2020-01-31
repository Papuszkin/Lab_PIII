using System;
using System.Collections.Generic;
using System.Text;

namespace Zajęcia14_Kolos
{
    public static class ExtensionMethods
    {
        public static string Cenowka(this double baza)
        {
            return Convert.ToString(Math.Round(baza, 2));
        }

        public static string Cenowka(this float baza)
        {
            return Convert.ToString(Math.Round(baza, 2));
        }
    }
}
