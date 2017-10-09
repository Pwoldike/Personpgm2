using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPgm2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] myIntArray = { 1, 7, 45, 43, 32 };
            SkrivArray();
            //int[,] myIntArray2;


            Array.Sort(myIntArray);
            SkrivArray();


            Array.Reverse(myIntArray);
            SkrivArray();

            // Array.Clear(myIntArray);

            //string[] myStringArray;
            //string[,] myStringArray2;

            DateTime d2 = DateTime.Now.AddSeconds(2);
            while (DateTime.Now < d2)
            {
                Console.WriteLine("*");
            }


            //myIntArray = new int[5];
            
            //Console.WriteLine(myIntArray[1]);

            //myIntArray2 = new int[1,1];
            //Console.WriteLine(myIntArray2[1,1]);

            Console.ReadKey();

            void SkrivArray()
            {
                Console.WriteLine("Array indeholder dette :");
                foreach (int item in myIntArray)
                {
                    Console.WriteLine(item);
                    Console.WriteLine("Number is : {0} ", item);
                }
            }
        }
        
    }
}
