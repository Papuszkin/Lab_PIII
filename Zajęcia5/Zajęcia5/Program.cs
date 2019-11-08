using System;

namespace Zajęcia5
{
    class Program
    {
        static void Stworz()
        {
            
        }

        static void Wyswietl()
        {
                
        }
        static void Main(string[] args)
        {
            //Napisz program wspomagający magazyn biblioteki
            //Każda ksiązka ma tytuł. 
            //Magazyn ma 3 regały
            //Regał ma 6 półek
            //Półka ma 10 miejsc na książki
            //Szukaj książki na podstawie tytułu

            // Tworzenie magazynu
            Ksiazka[,,] magazyn = new Ksiazka[3, 6, 10];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        magazyn[i, j, k] = new Ksiazka("Potop", "Sienkiewicz", i, j, k);
                    }
                }
            }


            magazyn[0, 2, 7] = new Ksiazka("Zatracenie", "Dazai", 2, 3, 3);

            // Wyswietlanie zawartosci magazynu
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Regał " + i);
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine("Półka " + j);
                    for (int k = 0; k < 10; k++)
                    {
                        Console.Write(magazyn[i, j, k].Autor + " \"" + magazyn[i, j, k].Tytul + "\" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            Console.Write("Tytuł szukanej książki: ");
            string szukane = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 10; k++)
                    {
                        if (magazyn[i, j, k].Autor == szukane || magazyn[i, j, k].Tytul == szukane)
                        {
                            Ksiazka znalezione = magazyn[i, j, k];
                            Console.WriteLine("Szukana książka znajduje się na " + znalezione.Regal + " regale, " + znalezione.Polka + " półce i na " + znalezione.Miejsce + " miejscu");
                        }
                    }
                }
            }
        }
    }
}
