using System;

namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            MeinContainer<int> A = new MeinConteiner<int>();
            A.Daten = 5;

            MeinContainer<String> B = new MeinContainer<string>();
            B.Daten = new Ferrari();

            Ferrari Brumm = new Ferrari();

            Console.WriteLine(Brumm);
        }
    }
}
