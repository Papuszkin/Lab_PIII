using System;
using System.Collections.Generic;
using System.Text;

namespace Zajęcia9
{
    public class PaperJammedEventArgs : EventArgs
    {
        public PaperJammedEventArgs(int page)
        {
            Page = page;
        }

        

        public int Page { get; set; }
    }
}
