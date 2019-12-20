using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zajęcia9
{
    class Printer
    {
        private Random _random;
        public event EventHandler<PaperJammedEventArgs> PaperJammed;
        public event EventHandler<OutOfInkEventArgs> OutOfInk;

        private List<Ink> _inks;

        public void Print(int pageNumber)
        {
            if (_random.NextDouble() < 0.01)
            {
                // generowanie Eventu
                // OnPaperJammed(EventArgs.Empty);
                PaperJammed.Invoke(this, new PaperJammedEventArgs(pageNumber));
            }
            else
            {
                Console.WriteLine("Etykieta");
                _inks.ForEach(x =>
                    {
                        x.Level -= _random.NextDouble() * 0.1;
                        if(x.Level <= 0)
                        {
                            OutOfInk.Invoke(this, new OutOfInkEventArgs(x.Color, pageNumber));
                        }
                    }
                );
            }
        }

        private void InternalEventHandler(object sender, PaperJammedEventArgs args)
        {
            Console.WriteLine($"[PRINTER JOG] Jammed at " +
                $"page {args.Page} at " +
                $"{DateTime.Now.ToLongDateString()} " +
                $"{DateTime.Now.ToLongTimeString()}");
        }

        private void OutOfInkInternalEventHandler(object sender, OutOfInkEventArgs args)
        {
            Console.WriteLine($"[PRINTER JOG] Cartrige {args.EmptyInk.ToUpper()} is empty " +
                $"at page {args.Page} " +
                $"{DateTime.Now.ToLongDateString()} " +
                $"{DateTime.Now.ToLongTimeString()}");
        }

        

        public Printer()
        {
            _inks = new List<Ink>();
            _inks.Add(new Ink("Cyan"));
            _inks.Add(new Ink("Yellow"));
            _inks.Add(new Ink("Magenta"));
            _inks.Add(new Ink("Black"));

            _random = new Random();
            PaperJammed += InternalEventHandler;
            OutOfInk += OutOfInkInternalEventHandler;
        }

        private class Ink
        {
            public Ink(string color)
            {
                Color = color;
                Level = 1;
            }

            public Ink(double level, string color)
            {
                Level = level;
                Color = color;
            }

            public double Level { get; set; }
            public string Color { get; set; }
        }
    }
}
