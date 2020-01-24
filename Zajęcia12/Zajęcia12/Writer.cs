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
            // Dodać metode tworzącą plik tekstowy dla każdej litery w alfabecie i umieścić w tych plikach 
            // dane osób na tą literę
        }
    }
}
