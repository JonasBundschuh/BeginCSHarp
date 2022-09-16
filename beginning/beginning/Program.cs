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
            //---------------RANDOM---------------
            Random rnd = new Random();
            int k = rnd.Next(0,36);
            Console.WriteLine($"The Number is: {k}");

            //---------------CASH---------------
            int entry = 10;
            int balance = 10000;
            int PlusBalance = balance + entry;
            int MinusBalance = balance - entry;

            //---------------BOOLS---------------
            bool winDouble;
            bool win0;
            bool generalWIN;
            bool loseEntry;

            if (generalWIN = true)
            {
                
                balance = balance + entry;
                entry = entry = 10;

            }
            else if (loseEntry = true)
            {
                balance = balance - entry;
                entry = entry * 2;
            }


            //---------------BALANCE CHANGE---------------
            if (balance < 10000)
            {
                entry = entry * 2;
            }
            else
            {
                entry = entry / 2;
            }

            

            //---------------WIN / LOSE---------------
            if (k % 2 == 0 && k != 0)
            {
                //$20
                winDouble = true;
                generalWIN = true;
            }
            else if (k % 2 == 0 && k != 1)
            {
                //-$10
                loseEntry = false;
                generalWIN = false;

            }
            else if (k == 0)
            {
                //$10
                win0 = true;

            }


            //---------------WIN---------------
            if (generalWIN = true)
            {
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Your entry was: {entry}");
                Console.WriteLine($"Your new balance = {PlusBalance}");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Press Enter to play again!");

            }else if(win0 = true)
            {
                Console.WriteLine("YOU WIN NOTHING");
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Your entry was: {entry}");
                Console.WriteLine($"Your new balance = {balance}");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Press Enter to play again!");
            }
            else
            {
                Console.WriteLine("YOU LOSE!");
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Your entry was: {entry}");
                Console.WriteLine($"Your new balance = {MinusBalance}");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Press Enter to play again!");
            }
            Console.ReadLine();
        }

       
    }   
}

