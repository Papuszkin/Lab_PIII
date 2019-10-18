//  Obliczanie średniej z przedmiotów podanych w konsoli

using System;

namespace Zajęcia3
{
    class Program
    { 
        static void Main(string[] args)
        {
            string[,] dziennik = new String[3,3];
            int nrPrzedmiotu = 0;
            
            for (int i = 0; i < 3; i++)
            {
                double suma = 0;
                double licznik = 0.0;
                double liczOcena;
                string ocena;

                // Zbieranie, sprawdzanie i operacja na podanych danych
                Console.Write("Podaj nazwę przedmiotu: ");
                string przedmiot = Console.ReadLine();
                do
                {
                    ocena = Console.ReadLine();
                    bool czyPrzekonwetowano = double.TryParse(ocena, out liczOcena);
                    if (czyPrzekonwetowano)
                    {
                        if (liczOcena >= 2 && liczOcena <= 5)
                        {
                            suma += liczOcena;
                            licznik++;
                        }
                        else
                        {
                            Console.WriteLine("To nie jest poprawna ocena/n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Podano niepoprawne dane");
                    }

                } while (liczOcena != 0);
                double srednia = suma / licznik;
                
                //  Dodawanie średnich i nazw przedmiotu do tablicy
                dziennik.SetValue(przedmiot, nrPrzedmiotu, 0);
                dziennik.SetValue(Convert.ToString(srednia), nrPrzedmiotu, 1);
                nrPrzedmiotu++;
            }

            //  Wypisywanie obliczonych średnich z tablicy
            Console.WriteLine("Otrzymane średnie:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(dziennik[i,j] + ": ");
                }
                Console.WriteLine("\nŚrednia całkowita: ");
            }

            //  Liczenie średniej całkowitej
            double temp = 0;
            for (int i = 0; i < 3; i++)
            {
                temp += Convert.ToDouble(dziennik[i, 1]);
            }
            Console.WriteLine(temp / 3);

        }
    }
}
