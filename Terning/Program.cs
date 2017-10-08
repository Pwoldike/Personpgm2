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
            Terning t = new Terning();
            t.Skriv();
            Terning t2 = new Terning(6);
            ////t2.Værdi = 2;
            t2.Skriv();

            LudoTerning t1 = new LudoTerning();
            t1.Skriv();

            Console.WriteLine("Er terning en globus : " + t1.ErGlobus());
            Console.WriteLine("Er terning en stjerne : " + t1.ErStjerne());

            Terning t3 = new LudoTerning(5);
            ////t3.Værdi = 5;
            t3.Skriv();

            ////Console.WriteLine("Er terning en globus : " +  t3.ErGlobus());
            ////Console.WriteLine("Er terning en stjerne : " + t3.ErStjerne());



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
            this.Værdi = rnd.Next(1, 6);
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
            Console.WriteLine("(" + Værdi + ")");
        }

        public LudoTerning() : base()     // default construktor ligesom base
        {

        }

        public LudoTerning(int værdi) : base(værdi) // custom construktor ligeson base
        { }
    }


    
}
