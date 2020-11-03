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

            ///////////////////////////////////

            bool JaOderNein; // exakt zwei wertr. true(1) und false (0)

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
