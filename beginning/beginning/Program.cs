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
                
            List<string> namen = new List<string>();
            
            //Console.WriteLine("Enter a name: ");
            Console.WriteLine("How many names do you want in the List?: ");
            int numberOfNames = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < numberOfNames; i++)
            {
                Console.WriteLine("Please enter a name to add to the list: ");
                string name = Console.ReadLine();
                namen.Add(name);

            }
            foreach (string name in namen)
            {
                Console.Clear();
                Console.WriteLine(name);
            }
         
            Console.ReadKey();
        }
        
    }
}


