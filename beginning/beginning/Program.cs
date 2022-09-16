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
            
            //Get user Input + Definitions
            Console.WriteLine("Please enter your first number: ");
            int numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter your second number: ");
            int numberTwo = Convert.ToInt32((Console.ReadLine()));

            Console.WriteLine("Please enter your Operator: ");
            string entered_operator = Console.ReadLine();
            Console.Clear();


            //math
            switch(entered_operator)
            {
                case "+":
                    float plus_equals = numberOne + numberTwo;
                    Console.Clear();
                    Console.WriteLine($"{numberOne} + {numberTwo} = {plus_equals}");
                    break;

                case "-":
                    float minus_equals = numberOne - numberTwo;
                    Console.Clear();
                    Console.WriteLine($"{numberOne} - {numberTwo} = {minus_equals}");
                    break;

                case "*":
                    float mult_equals = numberOne * numberTwo;
                    Console.Clear();
                    Console.WriteLine($"{numberOne} * {numberTwo} = {mult_equals}");
                    break;

                case "/":
                    float divide_equals = numberOne / numberTwo;
                    Console.Clear();
                    Console.WriteLine($"{numberOne} / {numberTwo} = {divide_equals}");
                    break;
            }



            Console.ReadKey();



        }
    }
}


