using System;
using System.Collections.Generic;
using System.Text;

namespace Zajęcia14_Kolos
{
    class Chleb : Produkt
    {
        public Chleb(string nazwa, double cena, string producent)
        {
            Nazwa = nazwa;
            Cena = cena;
            Producent = producent;
        }
    }
}
