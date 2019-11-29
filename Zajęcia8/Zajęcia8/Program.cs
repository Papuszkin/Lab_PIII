using System;

namespace Zajęcia8
{
    class Program
    {
        // Funkcja dla tablicy prostokatnej
        static int Najmniejsza(int [,] tablica)
        {
            int min = int.MaxValue;
            foreach (var item in tablica)
            {
                if (item < min)
                {
                    min = item;
                }
            }
            return min;
        }
        // Funkcja dla tablicy poszarpanej
        static int Najmniejsza(int [][] tablica)
        {
            int min = int.MaxValue;
            for (int i = 0; i < tablica.Length; i++)
            {
                for (int j = 0; j < tablica[i].Length; j++)
                {
                    if (tablica[i][j] < min)
                    {
                        min = tablica[i][j];
                    }
                }
            }
            return min;
        }

        static void Main(string[] args)
        {
            //// Zadanie 3 z kolowkwium
            // Ustalenie danych
            int[,] jeden = new int[3, 8];
            int[,] dwa = new int[5, 5];

            // Tworzenie tablicy wynikowej
            int rozmiar1 = Math.Max(jeden.GetLength(0), dwa.GetLength(0));
            int rozmiar2 = Math.Max(jeden.GetLength(1), dwa.GetLength(1));
            int[,] wynik = new int[rozmiar1, rozmiar2];

            // Dodawanie elementów z tablicy jeden
            for (int i = 0; i < jeden.GetLength(0); i++)
            {
                for (int j = 0; j < jeden.GetLength(1); j++)
                {
                    jeden[i, j] = 1;
                    wynik[i, j] += jeden[i, j];
                }
            }

            // Dodawanie elementów z tablicy dwa
            for (int i = 0; i < dwa.GetLength(0); i++)
            {
                for (int j = 0; j < dwa.GetLength(1); j++)
                {
                    dwa[i, j] = 1;
                    wynik[i, j] += dwa[i, j];
                }
            }

            // Wywwietlanie elementów
            Console.WriteLine("Tablica wynikowa: ");
            for (int i = 0; i < wynik.GetLength(0); i++)
            {
                for (int j = 0; j < wynik.GetLength(1); j++)
                {
                    Console.Write(wynik[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine();
            //// Zadanie 4 - szukanie liczby najmniejszej w tablicy
            // Ustalanie danych
            int[,] prostokatna = new int[3, 8];
            for (int i = 0; i < prostokatna.GetLength(0); i++)
            {
                for (int j = 0; j < prostokatna.GetLength(1); j++)
                {
                    prostokatna[i, j] = 1;
                }
            }
            prostokatna[2, 6] = -10;
            Console.WriteLine("Najmniejsza wartosc z tablicy: " + Najmniejsza(prostokatna));
        }
    }
}
