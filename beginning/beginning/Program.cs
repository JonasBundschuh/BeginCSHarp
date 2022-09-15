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

            Console.WriteLine("please enter some text: ");
            string entered_text = Console.ReadLine();
            bool capital_text = entered_text.Contains("abc");
            Console.Clear();
            Console.WriteLine(capital_text);
            


            Console.ReadLine();


        }
    }
}


