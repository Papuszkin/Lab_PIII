using System;
using System.Collections.Generic;
using System.Text;

namespace Zajęcia4
{
    public class Kalkulator
    {
        public static int Dodaj(int a, int b)
        {
            return a + b;
        }

        public static int Dodaj(string a, string b)
        {
            int liczA = Convert.ToInt32(a);
            int liczB = Convert.ToInt32(b);
            return liczA + liczB;
        }

        public static int Odejmij(int a, int b)
        {
            return a - b;
        }

        public static int Pomnoz(int a, int b)
        {
            return a * b;
        }

        public static double Podziel(int a, int b, out bool powodzenie)
        {
            if (b == 0)
            {
                powodzenie = false;
                return 0;
            }
            powodzenie = true;
            return (double)a / b;
        }

        public static double PodzielZWyjatkiem(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            return (double)a / b;
        }
        public static int Dodaj(int a, int b, int c)
        {
            return Dodaj(a, b) + c;
        }
    }
}
