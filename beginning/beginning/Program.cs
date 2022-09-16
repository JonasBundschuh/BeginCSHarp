using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace beginning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
         
            //get numbers from user input
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");

                } else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                } 
                else if (i % 3 == 0)
                {
                Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();

           // //print the numbers
           // for (int i = 0; i < numbers.Length; i++)
           // {
           //     Console.Clear();
           //
           //     Console.WriteLine($"Lowest Number: {numbers.Min()} ");
           //     Console.WriteLine($"Highest Number: {numbers.Max()}");
           //     Console.WriteLine($"Averge: {numbers.Average()}");
           // }
           // Console.ReadLine();

            

        }   
    }
}


