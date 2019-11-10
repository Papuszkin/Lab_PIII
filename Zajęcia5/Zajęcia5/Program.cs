//Napisz program wspomagający magazyn biblioteki
//Każda ksiązka ma tytuł. 
//Magazyn ma 3 regały
//Regał ma 6 półek
//Półka ma 10 miejsc na książki
//Szukaj książki na podstawie tytułu

using System;

namespace Zajęcia5
{
    class Program
    {
        /// <summary>
        /// Uzupełnia podaną tablice wartościami
        /// </summary>
        /// <param name="magazyn">Nazwa tablicy do wypełnienia</param>
        static void Wypelnij(Ksiazka[,,] magazyn)
        {
            for (int i = 0; i < magazyn.GetLength(0); i++)
            {
                for (int j = 0; j < magazyn.GetLength(1); j++)
                {
                    for (int k = 0; k < magazyn.GetLength(2); k++)
                    {
                        magazyn[i, j, k] = new Ksiazka("Potop", "Sienkiewicz", i, j, k);
                    }
                }
            }
        }

        /// <summary>
        /// Wypisuje zawartość podanej tablicy na ekran
        /// </summary>
        /// <param name="magazyn">Tablica do wyświetlenia</param>
        static void Wyswietl(Ksiazka[,,] magazyn)
        {
            for (int i = 0; i < magazyn.GetLength(0); i++)
            {
                Console.WriteLine("Regał " + i);
                for (int j = 0; j < magazyn.GetLength(1); j++)
                {
                    Console.WriteLine("Półka " + j);
                    for (int k = 0; k < magazyn.GetLength(2); k++)
                    {
                        Console.Write(magazyn[i, j, k].Autor + " \"" + magazyn[i, j, k].Tytul + "\" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Pobiera od użytkownika tekst i wyszukuje pasujących obiektów w tablicy, jeżeli znajdzie elementy to wypisze ich lokalizacje. Zwraca false przy braku pasujących elementów
        /// </summary>
        /// <param name="magazyn">Przeszukiwana tablica</param>
        /// <returns></returns>
        static bool Szukaj(Ksiazka[,,] magazyn)
        {
            bool czyZnaleziono = false;
            Console.Write("Tytuł szukanej książki: ");
            string szukane = Console.ReadLine();

            for (int i = 0; i < magazyn.GetLength(0); i++)
            {
                for (int j = 0; j < magazyn.GetLength(1); j++)
                {
                    for (int k = 0; k < magazyn.GetLength(2); k++)
                    {
                        if (magazyn[i, j, k].Autor == szukane || magazyn[i, j, k].Tytul == szukane)
                        {
                            Console.WriteLine("Szukana książka znajduje się na " 
                                    + (magazyn[i,j,k].Regal + 1) + " regale, " 
                                    + (magazyn[i, j, k].Polka + 1) + " półce i na " 
                                    + (magazyn[i, j, k].Miejsce + 1) + " miejscu");
                            czyZnaleziono = true;
                        }
                    }
                }
            }
            return czyZnaleziono;
        }

        static void Main(string[] args)
        {
            // Tworzenie magazynu
            Ksiazka[,,] magazyn = new Ksiazka[3, 6, 10];
            Wypelnij(magazyn);
            magazyn[0, 2, 7] = new Ksiazka("Zatracenie", "Dazai", 0, 2, 7);

            Wyswietl(magazyn);

            //Przeszukiwanie magazynu
            if (!Szukaj(magazyn))
            {
                Console.WriteLine("Brak pasujących elementów");
            }
        }
    }
}
