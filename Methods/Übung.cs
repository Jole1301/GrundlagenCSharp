using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class Übung
    {
        static void Main(string[] args)
        {
            int MyNumber = 25;
            int MyNewNumber = PostIncrement(MyNumber);

            PreIncrement(ref MyNumber);
        }

        static int PostIncrement(int newNumber)
        {
            newNumber = newNumber++;
            return newNumber;
        }

        static void PreIncrement(ref int newNumber)
        {
            newNumber = ++newNumber;
            Console.WriteLine(newNumber);
        }


    }
}
