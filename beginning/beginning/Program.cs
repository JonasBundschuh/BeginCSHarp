using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace beginning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(3);
            list.Add(7);

           

            Console.WriteLine("-----");
            Console.Write("Do you want to add more numbers to the list? ");
            string userAgree = Console.ReadLine();
            Console.Clear();
            bool continue_list = userAgree == "yes" == true;
            int userNumber = 0;
            do
            {
                Console.WriteLine("What number would you like to add?: ");
                string user_eingabe = Console.ReadLine();
                if(user_eingabe == string.Empty)
                {
                    continue_list = false;
                }
                else
                {
                    userNumber = Convert.ToInt32(user_eingabe);
                    list.Add(userNumber);
                }                
            } while (continue_list == true);

            Console.Clear();
            Console.WriteLine("-----");

            for (int i = 0; i < list.Count; i++)
            {

                Console.WriteLine(list[i]);

            }


            Console.ReadLine();







        }
    }   
}

