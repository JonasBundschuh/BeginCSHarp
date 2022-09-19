using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace beginning
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            
            List<Animals> animals = new List<Animals>();
            animals.Add(new Tiger("Tiger", "Raubtier", 12, 50, 15, 80, true, false, false, "ROOOAAAR" ));
           
            foreach(var animal in animals)
            {
                animal.PrintAnimal();
                animal.Geraeusche();
            }



            Console.ReadLine();

        }
    }
}

