using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zajęcia14_Kolos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1:");
            #region [Zad1]
            Random rnd = new Random();

            List<Pomiar> pomiary = new List<Pomiar>();
            for (int i = 0; i < 150; i++)
            {
                pomiary.Add(new Pomiar(
                    Math.Round(rnd.NextDouble() * rnd.Next(maxValue: 40, minValue: -10), 4),   // Temperatura
                    Math.Round(rnd.NextDouble() * rnd.Next(maxValue: 100, minValue: 0), 4),    // Wilgotność
                    Math.Round(rnd.NextDouble() * rnd.Next(maxValue: 100, minValue: 0), 4),    // Prędkośc wiatru
                    Math.Round(rnd.NextDouble() * rnd.Next(maxValue: 100, minValue: 0), 4),    // Ciśnienie
                    rnd.Next(maxValue: 2, minValue: 0)));
            }

            var minTemp = Math.Round(pomiary.Min(x => x.Temperatura), 2);
            var srTemp = Math.Round(pomiary.Average(x => x.Temperatura), 2);
            var maxTemp = Math.Round(pomiary.Max(x => x.Temperatura), 2);

            var minWilg = Math.Round(pomiary.Min(x => x.Wilgotność), 2);
            var srWilg = Math.Round(pomiary.Average(x => x.Wilgotność), 2);
            var maxWilg = Math.Round(pomiary.Max(x => x.Wilgotność), 2);

            var minPrW = Math.Round(pomiary.Min(x => x.PrWiatru), 2);
            var srPrW = Math.Round(pomiary.Average(x => x.PrWiatru), 2);
            var maxPrW = Math.Round(pomiary.Max(x => x.PrWiatru), 2);

            var minCisn = Math.Round(pomiary.Min(x => x.Cisnienie), 2);
            var srCisn = Math.Round(pomiary.Average(x => x.Cisnienie), 2);
            var maxCisn = Math.Round(pomiary.Max(x => x.Cisnienie), 2);

            Console.WriteLine("Pole\t|Min:\t|Sr:\t|Max:");
            Console.WriteLine($"Temp:\t|{minTemp}\t|{srTemp}\t|{maxTemp}");
            Console.WriteLine($"Wilg:\t|{minWilg}\t|{srWilg}\t|{maxWilg}");
            Console.WriteLine($"PrW:\t|{minPrW}\t|{srPrW}\t|{maxPrW}");
            Console.WriteLine($"Cisn:\t|{minCisn}\t|{srCisn}\t|{maxCisn}");
            #endregion

            Console.WriteLine("\nZadanie 2:");
            #region [Zad2]
            double cenaDouble = 2.1273;
            Console.WriteLine(cenaDouble.Cenowka());
            #endregion

            Console.WriteLine("\nZadanie 3:");
            #region [Zad3]
            List<Produkt> koszyk = new List<Produkt>();
            koszyk.Add(new Chleb("Bułka", 10.99, "Piekarnia"));
            koszyk.Add(new Chleb("Wek", 5.99, "Super Piekarnia"));
            koszyk.Add(new Sok("Pomarańcza", 3.99, "Sokarnia"));

            var koszt = koszyk.Sum(x => x.Cena);
            Console.WriteLine($"Cena zakupów wynosi: {koszt}");
            #endregion

            Console.WriteLine("\nZadanie 4:");
            #region [Zad4]
            var kierowca1 = new Kierowca("Kowalski", new DateTime(2021, 02, 12), KategoriePJ.A | KategoriePJ.C);
            var kierowca2 = new Kierowca("Tomaszewski", new DateTime(2019, 12, 30), KategoriePJ.B);

            Console.WriteLine("Kierowca {0} {1} prawo jazdy kategorii C", kierowca1.Nazwisko, kierowca1.Uprawnienia.HasFlag(KategoriePJ.C)? "ma" : "nie ma");
            Console.WriteLine("Kierowca {0} {1} prawo jazdy kategorii C", kierowca2.Nazwisko, kierowca2.Uprawnienia.HasFlag(KategoriePJ.C) ? "ma" : "nie ma");
            #endregion
            
            Console.WriteLine("\nZadanie 5:");
            #region [Zad5]
            var reader = new StreamReader("txt\\input.txt");
            string inputStream = reader.ReadToEnd();
            inputStream = inputStream.Replace(", ", "\n");

            var writer = new StreamWriter("txt\\output.txt");
            writer.Write(inputStream);
            writer.Close();
            reader.Close();
            Console.WriteLine("Dodano plik");
            #endregion
        }
    }
}
