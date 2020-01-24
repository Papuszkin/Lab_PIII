using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Zajęcia12
{
    class StreamFileReader : IReader
    {
        public List<Person> ReadPeople(string fileName)
        {
            var reader = new StreamReader(fileName);
            string data = reader.ReadToEnd();
            string[] lines = data.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
            var people = lines.Select(x =>
                CSVStringToPersonConverter.Convert(x)
            );
            return people.ToList();
            
        }
    }
}
