using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Filehandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] zahlenEinträge = new int[] { 1, 2, 3, 4, 5, 6, };
            double e2 = Ergebnis(zahlenEinträge);
            Console.WriteLine(e2);


            Console.ReadLine();
        }


        static int Ergebnis(int[] zahlenEinträge)
        {

            int ergebnis = 0;
            foreach(int i in zahlenEinträge)
            {
                ergebnis = i + ergebnis;
                
            }
            return ergebnis;
            
        } 


        //beide Zaheln addieren und das ergebnis wiedergeben


    }

}