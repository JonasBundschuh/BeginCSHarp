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

            Console.WriteLine("please enter a number: ");
            int entered_number = Convert.ToInt32(Console.ReadLine());
            int add = 0;
            for (int i = 0; i <= entered_number; i++)
            {
                Console.WriteLine($"Current Number: {i}");
                add = add + i;
                Console.WriteLine($"Added Number: {add}");
            }
            
            


            Console.ReadLine();


        }
    }
}


