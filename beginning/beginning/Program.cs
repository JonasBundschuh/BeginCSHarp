using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//comment

namespace beginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string entry = "This is a text containing words";
            string[] entries = entry.Split(' ');
            foreach (string entry2 in entries)
            {
                Console.WriteLine(entry2);
            }
            
            Console.ReadLine();
        }
    }
}


