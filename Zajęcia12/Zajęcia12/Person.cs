using System;
using System.Collections.Generic;
using System.Text;

namespace Zajęcia12
{
    public class Person
    {
        public Person(int iD, string name, string lastName, string phone)
        {
            ID = iD;
            Name = name;
            LastName = lastName;
            Phone = phone;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
    }
}
