// Dziedziczenie. Funkcje wirtualne. Polimorfizm
// Klasy i interfejsy generyczne - wstęp
// Delegaty, delegaty generyczne
// Omówienie delegatów wbudowanych
// Action, Action<>, Func<TOutput>, Fucn<, TOutput>, Predicate<T>

using System;

namespace Wykład10_s
{
    // Dziedziczenie, interface generyczny
    class Base<T>
    {
        public T Echo(T a) //T moze być dowolnym type (int, string, double)
        {
            return a;
        }
    }

    //class MyClass: Base
    //{
    //    public override void M()
    //    {
    //        Console.WriteLine("Base");
    //    }
    //}

    //class MyClass2: MyClass
    //{
    //    public override void M()
    //    {
    //        Console.WriteLine("MyClass2");
    //    }
    //}
    //// Koniec dziedziczenia

    class Person
    {
        public string Name { get; set; }
    }

    class Program
    {
        //// Dziedziczenie
        //static void Cps(Base b)
        //{
        //    b.M();
        //}

        static void Main(string[] args)
        {
            //// Dziedziczenie
            ////Cps(new Base()); - blokuje to abstrakcja
            //Cps(new MyClass());
            //Console.WriteLine();

            //Base[] collection = new[] { new MyClass(), new MyClass2() };
            //foreach (var item in collection)
            //{
            //    item.M();
            //}


            // Interfejsy generyczne
            var a = new Base<int>();
            var b = new Base<string>();
            var c = new Base<Person>();

            a.Echo(a: 10);
            var list = new Base<int>();
        }
    }
}
