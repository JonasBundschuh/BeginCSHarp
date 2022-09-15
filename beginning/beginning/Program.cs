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
            string trimmed_word = word.Trim(' ', 'a');

            Console.WriteLine("Old String" + word + ":");
            Console.WriteLine("New String " + trimmed_word + ":");

            Console.ReadLine();
        }
    }
}


