using System;
using System.Collections.Generic;

namespace Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {
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


            Console.WriteLine("Hello World!");
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
