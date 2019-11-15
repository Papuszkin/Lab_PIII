using System;
using System.Collections.Generic;
using System.Text;

namespace Zajęcia6
{
    class Samochod
    {
        public static int IloscModeli { get; private set; } = 0;

        public readonly string Model;

        public int VIN { get; set; }

        public void ZwiekszDystans(int dystans)
        {
            if (dystans < 0)
            {
                throw new Exception("Nie mozna zmiejszac dystansu");
            }
            else
            {
                Przebieg += dystans;
            }

        }

        private int _przebieg;
        public int Przebieg
        {
            get
            {
                return _przebieg;
            }
            set
            {
                if (value > _przebieg)
                {
                    _przebieg = value;
                }
            }
        }

        public int IloscDrzwi { get; private set; }

        private int _waga;
        public int Waga
        {
            get
            {
                return _waga;
            }
            set
            {
                _waga = value;
                if (_waga < 0)
                {
                    _waga = 0;
                }
            }
        }


        public Samochod(string model, int przebieg, int iloscDrzwi, int waga) : this()
        {
            Model = model;
            Przebieg = przebieg;
            IloscDrzwi = iloscDrzwi;
            Waga = waga;
        }

        public Samochod(int id)
        {
            // var dane = Baza.GetById(id);
            // Przebieg = dane.Przebieg;
        }

        public Samochod(int iloscDrzwi, int waga) : this("Multipla", 0, iloscDrzwi, waga)
        {
            // Ponieważ istnieje :this(...) instrukcje poniżej nie są wymagane
            //Model = "Multipla";
            //Przebieg = 0;
            //IloscDrzwi = iloscDrzwi;
            //Waga = waga;
            //VIN = IloscModeli++;
        }

        private Samochod()
        {
            VIN += IloscModeli++;
        }
    }
}
