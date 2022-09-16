using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace beginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[13];
            string[] names2 = new string[] { "Lukas", "Jonas", "Mona", "Marie", "Philip", "Jan", "Erwin", "Leon", "Marcello", "Johannes", "Robin", "Andreas", "Robert" };

            foreach(string trainee in names2)
            {
                Console.WriteLine(trainee);
            }

            Console.ReadLine();

            

        }   
    }
}


