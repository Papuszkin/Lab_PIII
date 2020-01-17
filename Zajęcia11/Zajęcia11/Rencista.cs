using System;
using System.Collections.Generic;
using System.Text;

namespace Zajęcia11
{
    class Rencista
    {

        public DateTime DataWażności { get; set; }
        public double Znizka { get; set; }
        public bool BezTerminowa { get; set; }

        public Rencista(DateTime dataWażności, double znizka)
        {
            if (dataWażności > DateTime.Now)
            {
                DataWażności = dataWażności;
            }
            Znizka = znizka;
            BezTerminowa = false;
        }

        public Rencista(bool bezTerminowa, double znizka)
        {
            BezTerminowa = bezTerminowa;
            DataWażności = new DateTime(9999, 12, 30);
            Znizka = znizka;
        }
    }
}
