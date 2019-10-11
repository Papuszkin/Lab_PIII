using System;

namespace Wyklad1
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var lk = rnd.Next(maxValue: 100);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Podejscie {0}", i);
                Console.WriteLine("Podaj liczbę: ");
                if (!int.TryParse(Console.ReadLine(), out int nl))
                {
                    continue;
                }

                if (nl > lk)
                {
                    Console.WriteLine("Za dużo");
                }
                else if (nl < lk)
                {
                    Console.WriteLine("Za mało");
                }
                else
                {
                    Console.WriteLine("Super man");
                    break;
                }
            }
        }
    }
}
