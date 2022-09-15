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
            int TextLenght = Text.Length;

            Console.Clear();
            Console.WriteLine("The original text was: " + Text);
            Console.WriteLine("The length of the entered text is: " + TextLenght);

            Console.ReadLine();
            
            
        }
    }
}


