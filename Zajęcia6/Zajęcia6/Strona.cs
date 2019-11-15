using System;
using System.Collections.Generic;
using System.Text;

namespace Zajęcia6
{
    class Strona
    {
        public Serwer SerwerStrony;
        public Domena DomenaStrony;

        public Strona(Serwer serwerStrony, Domena domenaStrony)
        {
            SerwerStrony = serwerStrony;
            DomenaStrony = domenaStrony;
        }
    }
}
