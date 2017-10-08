using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Personpgm2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person()
            {
                Efternavn = "t3",
                Fornavn = "y3"
            };
            Console.WriteLine(p.FuldtNavn());
            Console.WriteLine(p.FuldtNavn2());
            Console.WriteLine(p.GetHashCode());

            Elev e = new Elev() { Efternavn = "Elevsen", Fornavn = "Elev", KlasseLokale = "A202" };

            Console.WriteLine(e.FuldtNavn2());
            Console.WriteLine(e.KlasseLokale);

            Instruktør i = new Instruktør { Fornavn = "Instrutør", Efternavn = "Isen", NøgleId = 125 };

            string sti = NewMethod();
            if (!File.Exists(sti))
            {
                using (StreamWriter sw = File.CreateText(sti))
                {
                    sw.WriteLine(e.KlasseLokale);
                }
            }

            using (StreamWriter sw = File.AppendText(sti))
            {
                sw.WriteLine(e.Fornavn);
                sw.WriteLine(e.Efternavn);
                sw.WriteLine(e.Fornavn + e.Efternavn);
                sw.WriteLine(e.FuldtNavn2());
            }

            using (StreamWriter sw = File.AppendText(sti))
            {
                sw.WriteLine(i.NøgleId);
                sw.WriteLine(i.FuldtNavn2());
            }


            Console.ReadKey();
        }

        private static string NewMethod()
        {
            return @"E:\Person.txt";
        }
    }

    public class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public string FuldtNavn()
        {
            return Fornavn + " " + Efternavn;
        }
        public string FuldtNavn2()
        {
            return $"{Fornavn} {Efternavn}";
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    public class Elev : Person
    {
        public string KlasseLokale { get; set; }
    }

    public class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }
}
