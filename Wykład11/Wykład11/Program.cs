// Pattern Matching
// Deonstructing
// Yield
// Nowości w C# 8.0
// Kolekcje generyczne (Lins, Queue, Stack, Dictionary, HashSet, LinkedList)
// Pliki wtępowe tekst (wstęp)
using System;

namespace Wykład11
{
    class Program
    {
        class Person
        {
            public Person(string firstName, string lastName, string city, string state)
            {
                FirstName = firstName;
                LastName = lastName;
                City = city;
                State = state;
            }


            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public void Deconstruct(out string firstName, out string lastName)
            {
                firstName = FirstName;
                lastName = LastName;
            }

            public void Deconstruct(out string firstName, out string lastName, out string city, out string state)
            {
                firstName = FirstName;
                lastName = LastName;
                city = City;
                state = State;
            }
        }
        static void Main(string[] args)
        {
            var p = new Person(firstName: "Jan", lastName: "Kowalski", city: "BB", state: "Slaskie");
            var (firstName :string, lastname :string) = p;
        }
    }
}
