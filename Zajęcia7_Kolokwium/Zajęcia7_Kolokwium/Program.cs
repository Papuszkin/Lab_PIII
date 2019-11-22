// 3. Dodaj do siebie dwie prostokątne tablice o dowolnych wymiarach np. 3x5

using System;

namespace Zajęcia7_Kolokwium
{
    class Program
    {
        // 1. Otwórz n-ty wyraz ciągu arytmetycznego o wzorze y[n] = 1,5 * (y[n-1]) - 1. 
        //    Dla n=0 przyjmujemy stała wartość 1.
        static double y(int n)
        {
            double wynik = 0;
            if (n == 0)
            {
                wynik += 1;
                return wynik;
            }
            else
            {
                for (int i = n; i > 0; i--)
                {
                    wynik += 1.5 * y(n - 1) - 1;
                }
                return wynik;
            }
        }

        // 2. Stwórz tablicę 200 elementów i wypełnij ja liczbami 1-200. 
        //    Znajdź i wypisz wszystkie liczby podzielne przez liczbę podaną przez użytkownika.
        //    Pamiętaj o wartosci 0.
        static void podzielne()
        {
            // Tworzenie tablicy
            double[] tablica = new double[200];
            for (int i = 0; i < tablica.Length; i++)
            {
                int rnd = new Random().Next(1, 200);
                tablica[i] = rnd;
            }

            Console.Write("Podaj liczbe: ");
            string liczbaStr = Console.ReadLine();
            int liczbaInt = Convert.ToInt32(liczbaStr);
            if (liczbaInt == 0)
            {
                Console.WriteLine("Nie można dzielić przez zero");
            }
            else
            {
                foreach (double item in tablica)
                {
                    if (item % liczbaInt == 0)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            
        }

        // 3. Dodaj do siebie dwie prostokątne tablice o dowolnych wymiarach np. 3x5
        static void dodawanie()
        {
            int[,] A = new int[3, 10];
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    int rnd = new Random().Next(-30, 30);
                    A[i, j] = rnd;
                }
            }
            int[,] B = new int[10, 8];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    int rnd = new Random().Next(-30, 30);
                    B[i, j] = rnd;
                }
            }
            int szerososc = 0;
            int wysokosc = 0;

            // Sprawdzanie najwiekszej szerokosci
            if (A.GetLength(0) > B.GetLength(0))
            {
                szerososc = A.GetLength(0);
            }
            else
            {
                szerososc = B.GetLength(0);
            }

            // Szukanie najwiekszej wysokosci
            if (A.GetLength(1) > B.GetLength(1))
            {
                wysokosc = A.GetLength(1);
            }
            else
            {
                wysokosc = B.GetLength(1);
            }

            // Tworzenie tablicy i wypełnianie zerami
            int[,] C = new int[szerososc, wysokosc];
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    C[i, j] = 0;
                }
            }

            // Dodawanie tablic
            

            // Wypisywanie wyniku
            for (int i = 0; i < C.GetLength(0); i++)
            {
                for (int j = 0; j < C.GetLength(1); j++)
                {
                    Console.Write(C[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        // 4. Napisz funkcje, która przyjmie jako parametr tablice dwuwymiarowa prostokatna i wypisze jej najmniejszy element
        //    Stwórz przeładnowanie funkcji, która przyjmie tablice poszarpaną.
        //    Stwórz testowe dane.
        static void najmniejsza(int[,] tablica)
        {
            int min = tablica[0, 0];
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    if (tablica[i,j] < min)
                    {
                        min = tablica[i, j];
                    }
                }
            }
            Console.WriteLine("Najmniejszy element tablicy: " + min);
        }

        static void Main(string[] args)
        {
            // Wywałanie funkcji zadania 1
            Console.WriteLine("Podaj liczbe: ");
            string liczbaStr = Console.ReadLine();
            int liczbaInt = Convert.ToInt32(liczbaStr);
            Console.WriteLine(y(liczbaInt));
            Console.WriteLine();

            // Wywołanie funkcji zadania 2
            podzielne();
            Console.WriteLine();

            // Wywołanie funkcji zadania 3
            dodawanie();
            Console.WriteLine();

            // Wywołanie funkcji zadania 4
            int[,] tablica = new int[6, 10];
            for (int i = 0; i < tablica.GetLength(0); i++)
            {
                for (int j = 0; j < tablica.GetLength(1); j++)
                {
                    int rnd = new Random().Next(-20, 20);
                    tablica[i, j] = rnd;
                }
            }
            najmniejsza(tablica);
            Console.WriteLine();

            // Obiekt zadania 5
            EBook ksiazka = new EBook("Sapkowski", "Wiedzmin", new DateTime(2010, 12, 1), new DateTime(2019, 1, 1), 59.99, 10.0);
            ksiazka.Zakup(new DateTime(2018, 1, 1));
            Console.WriteLine("Autor: " + ksiazka.Autor +
                "\nTytuł: " + ksiazka.Tytul +
                "\nData wydania: " + ksiazka.DataWydania +
                "\nData ostatniego zakupu: " + ksiazka.DataOstatniegoZakupu +
                "\nCena standardowa: " + ksiazka.CenaStandardowa +
                "\nObniżka: " + ksiazka.Obnizka +
                "\nAktualna cena: " + ksiazka.AktualnaCena + "\n");

            EBook ksiazka2 = new EBook("Sapkowski", "Cyberpunk", new DateTime(2010, 12, 1), new DateTime(2019, 1, 1), -99.99, 10.0);
            Console.WriteLine("Autor: " + ksiazka2.Autor +
                "\nTytuł: " + ksiazka2.Tytul +
                "\nData wydania: " + ksiazka2.DataWydania +
                "\nData ostatniego zakupu: " + ksiazka2.DataOstatniegoZakupu +
                "\nCena standardowa: " + ksiazka2.CenaStandardowa +
                "\nObniżka: " + ksiazka2.Obnizka +
                "\nAktualna cena: " + ksiazka2.AktualnaCena + "\n");
        }
    }
}
