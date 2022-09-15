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
            //get searchValue
            Console.WriteLine("Please enter a character you want to search for: ");
            char searchValue = Convert.ToChar(Console.ReadLine());
            Console.Clear();

            //List of names
            string[] names = { "Jonas", "Phillip", "Niklas", "Marcello", "Andreas", "Robin", "Robert", "Marie", "Leon", "Erwin", "Jan", "Mona", "Lukas", "Johannes" };
            
            //Loop
            foreach(string name in names)
            {

                //if name on list contains searchValue print name
                bool valid_name = name.Contains(searchValue);
                if(valid_name.Equals(true))
                {
                    Console.WriteLine(name);
                }
            }
            Console.ReadLine();


        }   
    }
}


