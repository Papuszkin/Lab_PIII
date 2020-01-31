using System;
using System.Collections.Generic;
using System.Text;

namespace Zajęcia14_Kolos
{
    [Flags]
    public enum KategoriePJ
    {
        None = 0,
        AM = 1,
        A = 2,
        B  = 4,
        BE  = 8,
        C = 16,
        D  = 32,
    }
    class Kierowca
    {

        public string Nazwisko { get; set; }
        public DateTime WaznoscOC { get; set; }
        public KategoriePJ Uprawnienia { get; set; }

        public Kierowca(string nazwisko, DateTime waznoscOC, KategoriePJ uprawnienia)
        {
            Nazwisko = nazwisko;
            WaznoscOC = waznoscOC;
            Uprawnienia = uprawnienia;
        }
    }
}
