using System;
using System.Collections.Generic;

namespace Kontrollstrukturen
{

    class Program
    {
        static void Main(string[] args)
        {
            #region Bedinung 
            if (1 > 2) // testen einen ausdruck TRUE oder FALSE
            {
                // wenn 1 grösser ist als 2
            }

            if (1 < 2)
            {
                // wenn 1 kleiner als 2
            }
            else
            {
                // in jedem anderen fall
            }

            if (1 < 2 && 3 > 2) // und verknüpfung 
            {
                // wenn beide bedinungen erfüllt sind 
            }

            if (3 > 2 || 1 < 3 && 2 == 2)
            {

            }

            int VariableA;

            //          (bedinung       ? true : false)
            VariableA = (3 < 2 || 5 > 3 ? 5 : 3);
            
            
            switch(VariableA)
                {
                case 1:
                    // code wenn variable dem Fall 1 entspricht
                    break;
                case 2:
                    // code wenn variable dem Fall 2 entspricht
                    break;
                default:
                    // wenn kein case getroffen wurde
                    break;
            }

            Programmzustaende MeineGameEngine = Programmzustaende.Starting;

            switch (MeineGameEngine)
            {
                case Programmzustaende.Starting:
                    break;
                case Programmzustaende.Running:
                    break;
                case Programmzustaende.Stopping:
                    break;
                case Programmzustaende.Stopped:
                    break;
                case Programmzustaende.Paused:
                    break;

                default:
                    Console.WriteLine("#79587: Unbekannter systemzustand");
                    break;
            }

            switch (VariableA)
            {
                case 1:
                    MeineGameEngine = Programmzustaende.Paused;
                    break;
                case 2:
                    MeineGameEngine = Programmzustaende.Starting;
                    break;

                default:
                    MeineGameEngine = Programmzustaende.Stopped;
                    break;
            }

            MeineGameEngine = VariableA switch // kurzform erst ab C# in Version 8
            {
                1 => Programmzustaende.Paused,
                2 => Programmzustaende.Starting,
                _ => Programmzustaende.Stopped
            };


            #endregion

            #region Schleife

            int Anfang = 0;

            while (Anfang < 10)
            {
                Anfang++;
            }

            do
            {
                Anfang--;
            } while (Anfang > 0); // wanna see me do it again?;

            for (int counter = 0; counter < 10; counter++)
            {
            }

            for (;  ; Anfang++) // die bereiche des for sind alle optional for(;;) ist gültig
            {
                if (Anfang > 20)
                {
                    break;
                }
            }

            List<int> ListofNumbers = new List<int>();

            foreach (int item in ListofNumbers)
            {
                Console.WriteLine(item); 
            }

            ListofNumbers = null;

            do
            {
                Anfang--;
            } while (Anfang > 0);

            // goto sehr selten verwenden, wenn´s wirklich nicht anderes geht

        zielpunkt: // zielmarkierung für den goto-sprung

            Anfang--;

            if (Anfang > 0)
            {
            goto zielpunkt; // auslösung des sprungs 
            }

 
            #endregion
        }
    }
}
