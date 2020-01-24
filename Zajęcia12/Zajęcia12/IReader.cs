using System;
using System.Collections.Generic;
using System.Text;

namespace Zajęcia12
{
    interface IReader
    {
        List<Person> ReadPeople(string fileName);
    }
}
