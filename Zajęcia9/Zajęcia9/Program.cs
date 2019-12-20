using System;

namespace Zajęcia9
{
    class Program
    {
        private static bool _canPrint = true;
        static void PaperJammedEventHandler(object sender, PaperJammedEventArgs args)
        {
            Console.WriteLine($"Main: Paper Jammed at page {args.Page}");
            _canPrint = false;
        }

        static void OutOfInkEventHandler(object sender, OutOfInkEventArgs args)
        {
            Console.WriteLine($"Main: Replace {args.EmptyInk} Ink Cartrige");
            _canPrint = false;
        }

        static void Main(string[] args)
        {
            var printer = new Printer();
            printer.PaperJammed += PaperJammedEventHandler;
            printer.OutOfInk += OutOfInkEventHandler;
            for (int i = 0; i < 500; i++)
            {
                if (!_canPrint)
                {
                    break;
                }
                printer.Print(i);
            }
        }
    }
}


// Zadanie
// Drukarka ma 4 tusze: CMYK <0;1>
// Z każdym drukiem pobieramy z każdego tusza wartość, z czarnego <0.01,0.15> reszta <0,0.15>
// Gdy tusz się skończy to wyświetlamy błąd
