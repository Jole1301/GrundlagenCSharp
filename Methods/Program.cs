using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int MeineZahl = 12;
            int MeineNeueZahl = MethodeB(MeineZahl);

            MethodeC(ref MeineZahl);
        }
              static void MethodeA()
        { 
            Console.WriteLine("Methode A wurde gestartet");
        }    
        
        /// <summary>
        /// MethodeB erhält eine Zahl und erhöht sie um 2 gibt das ergebnis der addition zurück
        /// </summary>
        /// <param name="pZahl">Zahl die erhöht werden soll</param>
        /// <returns>Ergebnis des erhöhens um 2.</returns>
        
        static int MethodeB(int pZahl)
        {
            pZahl = pZahl + 2; // pZahl += 2; *** 12+2
            return pZahl;
        }

        /// <summary>
        /// Erhöht der Wert einer Variable um 2
        /// </summary>
        /// <param name="pZahl">Die Variable welche erhöht werden soll</param>

        static void MethodeC(ref int pZahl)
        {
            pZahl += 2;
            Console.WriteLine(pZahl);
        }

    }
}