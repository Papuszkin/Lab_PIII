using System;
using System.Linq;

namespace Wyklad6
{
    class Result
    {
        public Result(int value1, int value2)
        {
            Value1 = value1;
            Value2 = value2;
        }

        public int Value1 { get; }
        public int Value2 { get; }

        public override string ToString()
        {
            return $"Value1: {Value1}, Value2: {Value2}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 1, 0, 3, 3, 0, 2, 3 };
            var s = new[] { "ola", "kasia", "janusz", "ala" };

            //Tablica s jest indexem tablicy s
            Console.WriteLine("----------Indexowanie s za pomoca wartosci z a----------");
            var S1 = a.Select(x => s[x]);
            foreach (var item in S1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Sortowanie tablicy s po długości
            Console.WriteLine("----------Sortowanie po długości----------");
            var S2 = s.OrderBy(x => x.Length);
            foreach (var item in S2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Sortowanie tablicy po długości i alfabetycznie i żeńskie
            Console.WriteLine("----------Sortowanie po dlugosci, alfabetycznie i same żeńskie----------");
            var S3 = s
                .Where( x => x.EndsWith("a"))
                .OrderBy(x => x.Length)
                .ThenBy(x => x);
            foreach (var item in S3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Losowe 3 elementy z s
            Console.WriteLine("----------Losowe----------");
            var rnd = new Random();

            var S4 = s
                .OrderBy(x => rnd.Next(maxValue: 100))
                .Take(3);
            foreach (var item in S4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("----------Losowe 2----------");
            var S5 = s
                .OrderBy(x => Guid.NewGuid())
                .Take(3);
            foreach (var item in S5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Wybieranie częsci elementów
            Console.WriteLine("----------Wyświetlanie częsci elementów----------");
            var S6 = s.Skip(2).Take(2);
            foreach (var item in S6)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            //Pomijanie elementów
            Console.WriteLine("----------Pomijanie elementów dopóki nie dostanie spełniony warunek----------");
            var A4 = a.SkipWhile(x => x != 0);
            foreach (var item in A4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Wyswietlanie elementów dopóki nie zostanie spełniony warunek
            Console.WriteLine("----------Wyświetlanie elementów dopóki nie dostanie spełniony warunek--------");
            var A5 = a.TakeWhile(x => x != 0);
            foreach (var item in A5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Wybieranie kilku elementów z wyrażenia
            // Tworzenie nowej klasy
            Console.WriteLine("----------Kilka elementów z a (x, x+1) ver1----------");
            var A = a.Where(x => x % 2 == 0 && x > 0)
                .Select(x => new Result(x, x+1));

            foreach (var item in A)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Tworzenie klasy anonimowej
            Console.WriteLine("----------Kilka elementów z a (x, x+1) ver2----------");
            var A2 = a.Where(x => x % 2 == 0 && x > 0)
                .Select(x => new { x, Other = x + 1});

            foreach (var item in A2)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Zwrócić krotkę
            Console.WriteLine("----------Kilka elementów z a (x, x+1) ver3----------");

            var A3 = a.Where(x => x % 2 == 0 && x > 0)
                .Select(x => Tuple.Create(x, x + 1)); // Zamiast Tuple.Create() można dać po prostu w nawiasach (x, x+1)

            foreach(var item in A3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            //// Tylko liczby dodatnie (zwykła metoda)
            Console.WriteLine("----------Elementy dodatnie z a ver1----------");
            int[] b = new int[a.Length];
            int index = 0;
            foreach (var item in a)
            {
                if (item > 0)
                {
                    b[index++] = item;
                }
            }

            foreach (var item in b)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Metoda LINQ  (x => x > 0) - wyrażenie Lambda
            Console.WriteLine("----------Elementy dodatnie z a ver2----------");
            var c = a.Where(x => x > 0);
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
