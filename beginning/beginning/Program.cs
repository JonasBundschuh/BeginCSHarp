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
            Console.WriteLine("Enter a random Word: ");
            string word = Console.ReadLine();
            string replaced_word = word.Replace("Umd", "Gmc").Replace("u", "g");
            Console.WriteLine("the new text is: " + replaced_word);

            Console.ReadLine();
        }
    }
}


