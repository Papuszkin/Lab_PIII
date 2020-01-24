using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Zajęcia12
{
    public class CSVStringToPersonConverter
    {
        static public Person Convert(string csvstring)
        {
            string[] lineData = csvstring.Split(',');
            return new Person(System.Convert.ToInt32(lineData[0]), lineData[1], lineData[2], lineData[3]);
        }
    }
}
