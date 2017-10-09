using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Terning
{
    class Program
    {
        static void Main(string[] args)
        {
            //LudoTerning 1 = new LudoTerning();
            Terning[] terninger = new Terning[4];
            terninger[0] = new Terning();
            terninger[1] = new LudoTerning();
            terninger[2] = new LudoTerning();
            terninger[3] = new Terning();

            foreach (var item in terninger)
            {
                item.Skriv();
            }




            Console.ReadKey();
        }
    }

    public class Terning
    {
        private static Random rnd;
        private int værdi;

        public int Værdi
        {
            get
            {
                Console.WriteLine("Terning aflæses som : " + værdi);
                return værdi;
            }
            set
            {
                if (value < 0 || value > 6)
                {
                    value = 1;
                }
                Console.WriteLine("Terning tildeles værdi : " + value);
                værdi = value;
            }
        }
        public virtual void Skriv()
        {
            Console.WriteLine("[" + Værdi + "]");
        }

        public void Ryst()
        {
            this.Værdi = rnd.Next(1, 7);
        }

        public Terning()
        {
            Ryst();
        }

        public Terning(int værdi)
        {
            Værdi = værdi;
        }
        static Terning()
        {
            rnd = new Random();
        }

    }

    public class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            return Værdi == 3;
        }
        public bool ErStjerne()
        {
            return Værdi == 5;
        }
        public override void Skriv()
        {
            switch (Værdi)
            {
                case 3:
                    Console.WriteLine("[S]");
                    break;
                case 5:
                    Console.WriteLine("[G]");
                    break;
                default:
                    base.Skriv();
                    break;
            }
            Console.WriteLine("(" + Værdi + ")");
        }

        public LudoTerning() : base()     // default construktor ligesom base
        {

        }

        public LudoTerning(int værdi) : base(værdi) // custom construktor ligeson base
        { }
    }


    
}
