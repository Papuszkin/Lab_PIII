using System;
using System.Collections.Generic;
using System.Text;

namespace Zajęcia14_Kolos
{
    class Pomiar
    {

        public double Temperatura { get; set; }
        public double Wilgotność { get; set; }
        public double PrWiatru { get; set; }
        public double Cisnienie { get; set; }
        public int IDPracownika { get; set; }

        public Pomiar(double temperatura, double wilgotność, double prWiatru, double cisnienie, int iDPracownika)
        {
            Temperatura = temperatura;
            Wilgotność = wilgotność;
            PrWiatru = prWiatru;
            Cisnienie = cisnienie;
            if (iDPracownika >= 0 && iDPracownika <=2)
            {
                IDPracownika = iDPracownika;
            }
            else
            {
                iDPracownika = 0;
            }
        }
    }
}
