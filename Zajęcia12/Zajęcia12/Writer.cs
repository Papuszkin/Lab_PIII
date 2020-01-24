using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace Zajęcia12
{
    class Writer
    {
        public void WriteToFile(Person person, string filename)
        {
            StreamWriter writer = new StreamWriter(filename, true);
            writer.Write($"[{person.ID}] {person.Name} {person.LastName} {person.Phone}");
            writer.Close();
        }

        public void WritePhoneNumbers(List<Person> person, string filename)
        {
            StreamWriter writer = new StreamWriter(filename, false);
            foreach (var item in person)
            {
                writer.WriteLine($"{item.Phone}");
            }
            
            writer.Close();
        }

        public void SeperatePhoneNumbers(List<Person> person)
        {
            string filename = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                filename = "data\\" + Convert.ToString(i) + ".txt";
                StreamWriter writer = new StreamWriter(filename, false);
                var data = person.Skip(i * 10).Take(10);
                foreach (var item in data)
                {
                    writer.WriteLine($"{item.Phone}");
                }
                writer.Close();
            }
        }

        public void FileForEveryLetter(List<Person> person)
        {
            string filename = string.Empty;
            var znak = person.OrderBy(x=>x.Name).Select(x => x.Name[0]).Distinct();
            foreach (var item in znak)
            {
                filename = "otherdata\\" + Convert.ToString(item) + ".txt";
                StreamWriter writer = new StreamWriter(filename, false);
                var data = person.Where(x=> x.Name[0]==item);
                foreach (var selected in data)
                {
                    writer.WriteLine($"[{selected.ID}] {selected.Name} {selected.LastName} {selected.Phone}");
                }
                writer.Close();
            }
        }
    }
}
