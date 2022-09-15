using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age < 18)
            {
                Console.WriteLine("Youre underaged.");
            }
            else {
                Console.WriteLine("have fun");
                 }


            Console.ReadKey();
        }
    }
}


