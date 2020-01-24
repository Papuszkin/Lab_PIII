﻿using System;
using System.Linq;

namespace Zajęcia12
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamFileReader();
            var people = reader.ReadPeople("data.txt");

            var sortedPeople = people.OrderBy(x => x.LastName).ThenBy(x => x.Name);
            foreach (var person in sortedPeople)
            {
                Console.WriteLine($"{person.Name} {person.LastName}");
            }


            Writer writer = new Writer();
            writer.WriteToFile(sortedPeople.First(), "result.txt");

            writer.WritePhoneNumbers(sortedPeople.ToList(), "phones.txt");

            writer.SeperatePhoneNumbers(sortedPeople.ToList());
        }
    }
}
