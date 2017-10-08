using System;
using System.Runtime.InteropServices;

namespace Enum
{
    

    class Program
    {
        static void Main(string[] args)
        {
            FilTyper ft = FilTyper.csv;
            Console.WriteLine(ft);
            int t = (int)ft;
            Console.WriteLine(t);

            int ugeDagNr = 11;
            TjekUgeDag(ugeDagNr);

            TjekUgeDag(4);

            Console.ReadKey();
        }

        private static void TjekUgeDag(int ugeDagNr)
        {
            if (System.Enum.IsDefined(typeof(UgeDage), ugeDagNr))
            {
                Console.WriteLine((UgeDage)ugeDagNr);
            }
            if (!System.Enum.IsDefined(typeof(UgeDage), ugeDagNr))
            {
                Console.WriteLine("Forkert ugedagnr");
            }
        }

    }
    }

    public enum FilTyper
    {
        pdf,
        txt,
        csv
    }

    public enum UgeDage
    {
        mandag = 1,     // integer value = 0
        tirsdag = 2,    // 1
        onsdag = 3,     // 2
        torsdag = 4,
        fredag = 5,
        lørdag = 6,
        søndag = 7

    }
    



    

