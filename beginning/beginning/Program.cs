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
            //Number1
            Console.WriteLine("please enter some text: ");
            string entered_text = Console.ReadLine();

            string filled_text = entered_text.PadLeft(20,'Y');

            Console.Clear();
            Console.WriteLine(filled_text);
            

            Console.ReadLine();
            
            
        }
    }
}


