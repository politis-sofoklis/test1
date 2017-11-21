using System;
using System.Collections.Generic;

namespace Excercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lista = new List<string> { "i" ,"t", "t", "t", "k", "t", "t", "t" };
            List<string> lista1 = Utilities.LongestSubsGen(lista);
            foreach (string item in lista1)
            {
                Console.WriteLine(item);
            }
            
            //int x = 6;
            //int y = 5;
            //Utilities.Swap(ref x, ref y);
            //string z = "stelios";
            //string k = "kontelas";
            //Utilities.SwapGen(ref z, ref k);
            //Console.WriteLine(z);
            //Console.WriteLine(k);
            Console.ReadKey();

        }
    }
}
