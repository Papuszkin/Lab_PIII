using System;
using System.Collections.Generic;
using System.Linq;
using RandomDataGenerator.Randomizers;
using RandomDataGenerator.FieldOptions;
using System.Diagnostics;

namespace Zajęcia8_LINQ
{
    public class Osoba
    {
        public int id;
        public string imie;
        public string nazwisko;
        public int wiek;
        public string kraj;

        public Osoba(int id, string imie, string nazwisko, int wiek, string kraj)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
            this.kraj = kraj;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //// Wejsciowa lista o nazwie "lista"
            //Console.WriteLine("Dane wejsciowe:");
            //List<int> lista = Enumerable.Range(100, 150).ToList();
            //foreach (var item in lista)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine("\n");
            //// Elementy podzielne przez 3
            //List<int> podzielnePrzez3 = lista.Where(x => x % 3 == 0).ToList();
            //Console.WriteLine("Elementy podzielne przez 3");
            //foreach (var item in podzielnePrzez3)
            //{
            //    Console.Write(item + " ");
            //}

            //Console.WriteLine("\n");
            //// Srednia z elementów podzinych przez 3
            //double srednia = podzielnePrzez3.Average();
            //Console.WriteLine("Srednia to: " + srednia);

            //Console.WriteLine();
            //// Suma elementow podzielnych przez 3
            //int suma = podzielnePrzez3.Sum();
            //Console.WriteLine("Suma elementów podzielnych przez 3 to: " + suma);

            //Console.WriteLine();
            //// Paginacja
            //int nrStrony = 2;
            //int elemNaStronie = 10;
            //var strona = lista.Skip(elemNaStronie * (nrStrony - 1))
            //                  .Take(elemNaStronie);
            //Console.WriteLine("Elementy ze strony " + nrStrony + ":");
            //foreach (var item in strona)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //// Tworzenie listy osob na podstawie klasy Osoba
            //List<Osoba> osoby = lista.Select(
            //    x => new Osoba()
            //    {
            //        id = x,
            //        imie = x.ToString(),
            //        nazwisko = "aaa"
            //    }
            //    ).ToList();
            //Console.WriteLine("Dostepne osoby");
            //foreach (var item in osoby)
            //{
            //    Console.WriteLine($"{item.id}: {item.imie} {item.nazwisko}");
            //}

            //Console.WriteLine();
            //// Wyciaganie listy nazwisk
            //Console.WriteLine("Lista wszystkich nazwisk");
            //List<string> nazwiska = osoby.Select(x => x.nazwisko).ToList();
            //foreach (var item in nazwiska)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //// Wyciaganie listy unikatowych nazwisk
            //Console.WriteLine("Lista unikalnych nazwisk:");
            //osoby[45].nazwisko = "bbb";
            //List<string> unikalneNazwiska = osoby.Select(x => x.nazwisko).Distinct().ToList();
            //foreach (var item in unikalneNazwiska)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //// Wyszukiwanie pierwszej osoby o podanym naziwsku
            //Console.WriteLine("Pierwsza osoba o nazwisku 'aaa'");
            //Osoba szukana = osoby.First(x => x.nazwisko == "aaa");
            //Console.WriteLine($"{szukana.id}: {szukana.imie} {szukana.nazwisko}");


            var nameGen = RandomizerFactory.GetRandomizer(new FieldOptionsFirstName());
            var lastNameGen = RandomizerFactory.GetRandomizer(new FieldOptionsLastName());
            var ageGen = RandomizerFactory.GetRandomizer(new FieldOptionsInteger {Min = 1, Max = 100});
            var countryGen = RandomizerFactory.GetRandomizer(new FieldOptionsCountry());

            List<Osoba> osoby = Enumerable.Range(1, 1500).Select(
                    x => new Osoba(x, nameGen.Generate(), lastNameGen.Generate(), ageGen.Generate().Value , countryGen.Generate())
                ).ToList();
            foreach (var item in osoby)
            {
                Console.WriteLine($"{item.id}: {item.imie} {item.nazwisko} {item.wiek} {item.kraj}");
            }
            

            // Sortowanie po nazwisku a następnie po imieniu
            List<Osoba> posortowane = osoby.OrderBy(x => x.nazwisko).ThenBy(x => x.imie).ToList();
            foreach (var item in posortowane)
            {
                Console.WriteLine($"{item.id}: {item.imie} {item.nazwisko} {item.wiek} {item.kraj}");
            }

            Console.WriteLine();
            // Wyszukiwanie danych
            Console.Write("Szukany kraj: ");
            string krajSz = Console.ReadLine();
            Console.Write("Minimalny wiek: ");
            string wiekMi = Console.ReadLine();
            int wiekMin = Convert.ToInt32(wiekMi);
            Console.Write("Maksymalny wiek: ");
            string wiekMa = Console.ReadLine();
            int wiekMax = Convert.ToInt32(wiekMa);


            List<Osoba> szukane = osoby.Where(x => x.kraj == krajSz && x.wiek > wiekMin && x.wiek < wiekMax).ToList();
            Console.WriteLine("\n Wynik wyszukiwania:");
            foreach (var item in szukane)
            {
                Console.WriteLine($"{item.id}: {item.imie} {item.nazwisko} {item.wiek} {item.kraj}");
            }
        }
    }
}
