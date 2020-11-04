using System;
using System.Collections.Generic;

namespace Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Datentypen und Konteiner

            Console.WriteLine("asdas");

            long Ganzzahlen64Bit; // -9 trillionen bis 9 trillionen
            ulong Ganzzahlen64BitPositiv; // 0 bis 18 trillionen



            int Ganzzahl32Bit; // -2,14 bis 2,14 Milliarden
            uint Ganzzahl32BitPositiv; // 0 bis 4.29 Milliarden

            short Ganzzahl16Bit; // -32 tausend bis 32 tausend
            ushort Ganzzah16BitPositiv; // 0 bis 65 tausend

            sbyte Ganzzahl8Bit; // -128 bis 127
            byte Ganzzahl8BitPositiv; // 0 bis 255

            /////////////////////////////////

            float Gleitkommazahl32Bit; // ca 6 stellen genau
            double Gleitkommazahlen64Bit; // ca 15 stellen genau
            decimal Gleitkommazahlen128Bit; // ca 30 stellen genau

            ///////////////////////////////////

            bool JaOderNein; // exakt zwei wertr. true(1) und false (0)

            //////////////////////////////////

            byte AktiveOptionen = (byte)(MyEnum.A | MyEnum.D);

            ////////////////////////////////

            string Text = "Mein Text"; // Text mit einem NULL als verstecktes ende-zeichen 
            char Buchstabe = 'B'; // 16Bit
            string BuchstabeAlsString = ""; // Ein Text mit der länge 0

            ///////////////////////////////////

            byte[] ByteArray = new byte[20]; // erstellen ein Array von 20 byte, feste länge, immer hintereinander
            // 1. new wird aufgerufen mit der Parameter byte[20], damit weiss new wieviel arbeitspeicher benötig wird und 
            // fordert diesen von dem Betriebssystem 
            // ".new startet den Konstruktor von dem frisch erstellen Objekt
            // 3. new endet mit einem return wert, welcher die arbeitsspeicheradresse des objektes enthält
            // 4. der Rückgabewert von new wird in der Variable ByteArray gespeichert

            List<byte> ListOfByte = new List<byte>(); // erstellen ein List-Objekt welches als kontainer für bytes
            // ausgelegt wurde. dynamische länge, immer hintereinander.
            // Fordert versteckt mehr arbeitsspeicher an als nötig damit elemente angefügt werden können
            // Sollte der angeforderte RAM nicht reichen wird neuee Arbeitsspeicher in doppelter grösse angelegt
            // die alten werte in den neuen bereich kopiert und der alte RAM freigegeben
            List<byte> ListOfThousendByte = new List<byte>(1024); // legt die anfangsgrösse des RAM fest
            // ListOfThousendByte.Count enthält die anzahl der elemente 
            // ListOfThousendByte.Capacity enthält die grösse der Liste 

            LinkedList<byte> LinkedListOfByte = new LinkedList<byte>(); // erstellen eine LinkedList
            // dynamische länge, nicht hintereinander im RAM,Einfügen und löschen überall erlaubt
            #endregion


            int A = 4;
            int B = 9;
            int AdditionErgebnis = A + B; // 13
            int SubtraktionsErgebnis = A - B; // -5
            int DivisionsErgebnis = A / B; // 0
            int MultiplikationsErgebnis = A * B; // 36
            int ModuloErgebnis = A % B; // rest 4

            int IncrementErgebnisA = A++; // 4, A wird nach der Benutzung raufgezählt 
            int IncrementErgebnisB = ++B; // 10, B wird vor der Benutzung raufgezählt


            /// Übung
            /// 

            int Alpha = 4;
            int Bravo = 6;

            // Alpha = 5
            // Bravo = 7
            //      11        4     +     7
            int ErgebnisA = Alpha++ + ++Bravo;

            int Charly = 4;
            int Delta = 6;

            // Charly = 6
            // Delta = 9
            //                  5    +    5     +     7   +     8   +   8
            int ErgebnisB = ++Charly + Charly++ + ++Delta + ++Delta + Delta++;

            Console.WriteLine(ErgebnisA);
            Console.WriteLine(ErgebnisB);
        } // ende Main

        enum MyEnum
        {
            A = 1,
            B = A*2,
            C = B*2,
            D = C*2
        }
    }
}
