using System;
using System.Collections.Generic;
using System.Text;

namespace Zajęcia6
{
    class Domena
    {
        public readonly string nazwa;

        DateTime _waznosc;
        public DateTime Waznosc { get; private set; }


        public string technologia;

        public Domena(string nazwa, DateTime waznosc, string technologia)
        {
            this.nazwa = nazwa;
            this.Waznosc = waznosc;
            this.technologia = technologia;
        }

        public void ZmienWaznosc(DateTime nowadata)
        {
            if (nowadata < Waznosc)
            {
                Console.WriteLine("Nie można skrócic okresu ważności");
            }
            else
            {
                Waznosc = nowadata;
            }
        }
    }
}
