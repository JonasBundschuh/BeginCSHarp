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
            //Number1
            Console.WriteLine("please enter a deciaml number: ");
            decimal entered_number1 = Convert.ToDecimal(Console.ReadLine());

            //Number2
            Console.WriteLine("Please enter a second decimal number: ");
            decimal entered_number2 = Convert.ToDecimal(Console.ReadLine());

            decimal sum = entered_number1 + entered_number2;

            Console.Clear();
            Console.WriteLine("The sum of the 2 numbers you entered is: " + sum);

            Console.ReadLine();
            
            
        }
    }
}


