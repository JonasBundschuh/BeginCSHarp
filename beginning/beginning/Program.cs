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
            //GetText
            Console.WriteLine("please enter some text: ");
            string Text = Console.ReadLine();
            string replaced_text = Text.Replace('U', 'G').Replace('u', 'g');

            Console.Clear();
            Console.WriteLine("Original Text: " + Text);
            Console.WriteLine("Replaced Text: " + replaced_text);

            Console.ReadLine();
            
            
        }
    }
}


