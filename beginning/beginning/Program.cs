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

            Console.WriteLine("please enter your first number: ");
            int z1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("please enter your second number: ");
            int z2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Please enter your operator: ");
            string chosen_operator = Console.ReadLine(); 


            int Add_ergebnis = Add(z1, z2);
            int minus_ergebnis = Minus(z1, z2);
            float divide_ergebnis = divide(z1, z2);
            float multi_ergebnis = multi(z1, z2);

            if(chosen_operator == "+")
            {
                Console.Clear();
                Console.WriteLine($"{z1} + {z2} = {Add_ergebnis}");
            }
            else if(chosen_operator == "-")
            {
                Console.Clear();
                Console.WriteLine($"{z1} - {z2} = {minus_ergebnis}");
            }
            else if(chosen_operator == "/")
            {
                Console.Clear();
                Console.WriteLine($"{z1} / {z2} = {divide_ergebnis}");
            }
            else if(chosen_operator == "*")
            {
                Console.Clear();
                Console.WriteLine($"{z1} * {z2} = {multi_ergebnis}");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Operator!");
            }
            //Console.WriteLine(/*/t*/);

            Console.ReadKey();
            
        }

        static int Add(int z1, int z2)
        {
            int sum = z1 + z2;
            return sum;
        }

        static int Minus(int z1, int z2)
        {
            int m = z1 - z2;
            return m;
        }

        static int divide(int z1, int z2)
        {
            int d = z1 / z2;
            return d;
        }

        static float multi(int z1, int z2)
        {
            int u = z1 * z2;
            return u;
        }
        
    }
}


