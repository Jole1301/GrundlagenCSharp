using System;

namespace Datentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            long Ganzzahlen64Bit; // -9 trillionen bis 9 trillionen
            ulong Ganzzahlen64BitPositiv; // 0 bis 18 trillionen



            int Ganzzahl32Bit; // -2,14 bis 2,14 Milliarden
            uint Ganzzahl32BitPositiv; // 0 bis 4.29 Milliarden

            short Ganzzahl16Bit; // -32 tausend bis 32 tausend
            ushort Ganzzah16BitPositiv; // 0 bis 65 tausend

            sbyte Ganzzahl18Bit; // -128 bis 127
            byte Ganzzahl18BitPositiv; // 0 bis 255

            /////////////////////////////////

            float Gleitkommazahl32Bit; // ca 6 stellen genau
            double Gleitkommazahlen64Bit; // ca 15 stellen genau
            decimal Gleitkommazahlen128Bit; // ca 30 stellen genau

            Console.WriteLine("Hello World!");
        }
    }
}
