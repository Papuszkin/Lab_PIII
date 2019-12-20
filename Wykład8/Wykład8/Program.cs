using System;
using System.Linq;

namespace Wykład8
{
    interface ICanFly
    {
        void Fly();
    }

    interface ICanSwim
    {
        void CanSwim();
    }

    class Fish : ICanSwim
    {
        public void CanSwim()
        {
            Console.WriteLine("Swim");
        }
    }

    class SuperHero : ICanFly, ICanSwim
    {
        public void CanSwim()
        {
            Console.WriteLine("SuperHero Swim");
        }

        public void Fly()
        {
            Console.WriteLine("SuperHero Fly");
        }
    }

    class Program
    {
        static void M(ICanFly canSwim)
        {
            canSwim.Fly();
        }

        static void Main(string[] args)
        {
            //// Dzialanie operacji ZIP
            //int[] a = { 1, 2, 3, 4 };
            //string[] b = { "ala", "kasia", "Karol", "a", "b", "c", "d" };

            //var c = a.Zip(b, (i, s) => new { i, s });

            //foreach (var item in c)
            //{
            //    Console.WriteLine(item);
            //}


            //// Generator Lotto
            //var l = Enumerable.Repeat(
            //    Enumerable.Range(1, 49)
            //    .OrderBy(x => Guid.NewGuid())
            //    .Take(6)
            //    ,10);

            //Console.WriteLine("".PadRight(totalWidth: 30, paddingChar: '-'));

            //foreach (var item in l)
            //{
            //    Console.WriteLine(string.Join(separator: ", ", values: item));
            //}


            // SOLID
            // S - Single Responsibility (pojedyńcza odpowiedzialność)
            // O - 
            // L - 
            // I - Interface Segregation
            // D - 

            
        }
    }
}
