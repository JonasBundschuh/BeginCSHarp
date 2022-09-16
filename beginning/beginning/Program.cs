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
            //ask use how many logs he wants
            Console.WriteLine("How many logs do you want?: ");
            int log_amount = Convert.ToInt32(Console.ReadLine()); 

            int[] numbers = new int[log_amount];
           // int[] numbers2 = new int[] { 26, 8, 12, 3, 6 };


            //get numbers from user input
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Give me a number for the array: ");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            Console.Write("[ ");


            //print the numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} | ");
            }


            Console.Write(" ]");

            Console.ReadLine();

            

        }   
    }
}


