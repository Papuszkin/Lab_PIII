using System;
using System.Collections.Generic;
using System.Text;

namespace Zajęcia10
{
    [Flags]
    public enum TypOsoby
    {
        Brak = 0,      // [00000]
        Niemowle = 1,  // [00001]
        Dziecko = 2,   // [00010]
        Mlodziez = 4,  // [00100]
        Dorosly = 8,   // [01000]
        Starszy = 16   // [10000]
    }

    [Flags]
    public enum Zainteresowania
    {
        Elektronika,
        Motoryzacja,
        Gaming,
        Edukacja
    }
}
