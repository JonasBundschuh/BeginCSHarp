using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is yoir height? ");
            decimal height = Convert.ToDecimal(Console.ReadLine());
            decimal multiplicator = 3;
            Console.WriteLine("Youre " + height * multiplicator + " high");


            Console.ReadKey();
        }
    }
}


