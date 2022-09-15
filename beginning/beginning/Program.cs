using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //NumberOne
            Console.WriteLine("Nenne die erste Zahl: ");
            int NumberOne = Convert.ToInt32(Console.ReadLine());

            //NumberTwo
            Console.WriteLine("Nenne die zweite Zahl: ");
            int NumberTwo = Convert.ToInt32(Console.ReadLine());

            //sum
            int Numbersum = (NumberOne + NumberTwo);
            Console.Clear();
            Console.WriteLine(NumberOne + " + " + NumberTwo + " = " +Numbersum);

            Console.ReadLine();
            
            
        }
    }
}


