// Testy jednostkowe
using System;
using System.Linq;
using System.Collections;


namespace Wykład13
{
    class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // AAA
            // 1. Arrange
            var calc = new Calculator();

            // 2. Act
            var actual = calc.Add(1, 2);

            // 3. Assert
            Assert(3, actual);

        }

        private static void Assert(int expected, int actual)
        {
            Console.WriteLine("{0} - {1} {2}",expected, actual, expected==actual? "Positive" : "Negative");
        }
    }
}
