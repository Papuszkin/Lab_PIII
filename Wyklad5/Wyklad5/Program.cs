 using System;

namespace Wyklad5
{
    class MyClass
    {
        // Właściwość klasy, umożliwia ukrywanie wartości dla klas potomnych (hermentyzacja)
        // Standardowo pola nazywamy zaczynając _ i pisząc z małych liter
        // Właściwości piszemy z dużych liter


        //private const double toRad = Math.PI / 180;
        //private const double toDeg = 1 / toRad;
        //private double _degree;
        //public double Degree {
        //    get
        //    {
        //        return _degree * toDeg;
        //    }
        //    set
        //    {
        //        _degree = value * toRad;
        //    }

        public string Name { get; private set; } = "Jan";
        public int Age { get; set; }

        public MyClass(string name)
        {
            Name = name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        // Nie posiadając settera można ustalić wartość przy tworzeniu właściwości lub w konstruktorze

        // Destruktor obiektu, nie jest wykożystywany do zwalniania pamięci a np do zrywania połączenia z bazą danych
        ~MyClass()
        {

        }

    }

    class Address
    {
        public Address(string city, string street)
        {
            City = city;
            Street = street;
        }

        public string City { get; set; }
        public string Street { get; set; }

        
    }

    class Person
    {
        public string Name { get; set; }
        //Kompozycja to zagnieżdzanie klasy w klasie
        public Address Address { get; set; }

        public Person(string name, Address address)
        {
            Name = name;
            Address = address;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
