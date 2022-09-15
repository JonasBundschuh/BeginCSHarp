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
            string substring_word = word.Substring(3, 4);
;           Console.WriteLine("old word: " + word);
            Console.WriteLine("new word: " + substring_word);  

            Console.ReadLine();
        }
    }
}


