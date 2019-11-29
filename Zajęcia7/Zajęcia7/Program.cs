using System;
using System.Collections.Generic;
using System.Linq;

namespace Zajęcia7
{
    class Sala
    {
        public int numer;
        public int iloscMiejsc;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tworzenie podstawowej listy 100 elementowej zaczynając od 1
            List<int> lista = Enumerable.Range(1, 100).ToList();
            foreach (var element in lista)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // Lista elementów podzielmych przez 3
            List<int> podzielnePrzez3 = lista.Where(x => x % 3 == 0).ToList();
            foreach (var element in podzielnePrzez3)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // Podział na strony
            IEnumerable<int> stronaDruga = podzielnePrzez3.Skip(10).Take(30);
            foreach (var element in stronaDruga)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // Wartosc srednia
            double srednia = lista.Average();
            Console.WriteLine("Srednia z calej listy to: " + srednia);
            Console.WriteLine();

            // Suma elementów listy
            int suma = lista.Sum();
            Console.WriteLine("Suma z całej listy to: " + suma);
            Console.WriteLine();

            // Dzialanie na klasie Sala
            // Wypelnianie listy obiektami sala
            List<Sala> sale = lista.Select(x => new Sala() { numer = x, iloscMiejsc = 50 }).ToList();
            foreach (var item in sale)
            {
                Console.WriteLine($"Sala nr {item.numer} : {item.iloscMiejsc}");
            }
            Console.WriteLine();

            // Tworzenie listy z pojemnosciami sal
            List<int> pojemnosci = sale.Select(x => x.iloscMiejsc).ToList();
            foreach (var item in pojemnosci)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Unikatowa lista pojemnosci
            sale[45].iloscMiejsc = 100;
            sale[60].iloscMiejsc = 20;
            List<int> listaPojemnosci = sale.Select(x => x.iloscMiejsc).Distinct().ToList();
            foreach (var item in listaPojemnosci)
            {
                Console.WriteLine(item);
            }
        }
    }
}
