using System;
using System.Collections.Generic;
using System.Text;

namespace Zajęcia9
{
    class OutOfInkEventArgs : EventArgs
    {
        public OutOfInkEventArgs(string emptyInk, int page)
        {
            EmptyInk = emptyInk;
            this.Page = page;
        }

        public string EmptyInk { get; set; }
        public int Page { get; set; }
    }
}
