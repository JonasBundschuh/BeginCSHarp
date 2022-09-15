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
            //name
            Console.WriteLine("Username: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName);

            //age
            Console.WriteLine("What is your age right now: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Youre: " + age + " years old.");

            //futureAge and Sum. Introduction
            Console.WriteLine("How old are you in X years? ");
            int nextYear = Convert.ToInt32(Console.ReadLine()); 
            int sumYears = age + nextYear;
            Console.WriteLine("In " + nextYear + " Years you will be " + sumYears);


            Console.ReadKey();
        }
    }
}
