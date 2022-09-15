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

            {
                Console.WriteLine("Enter your Number: ");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                while (numberOne > 0)
                {
                    numberOne--;
                    Console.WriteLine(numberOne);

                }

                Console.ReadKey();
            }

        }   
    }
}


