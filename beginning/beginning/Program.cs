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
            Console.WriteLine("What is your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Youre: " + age + " years old.");


            Console.ReadLine();
        }
    }
}
