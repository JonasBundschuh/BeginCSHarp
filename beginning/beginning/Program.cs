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

            Console.WriteLine("How many houses would u like to add?: ");
            int AmountHouses = Convert.ToInt32(Console.ReadLine());

            Console.Clear();


            List<House> Houses = new List<House>();

            for (int i = 0; i < AmountHouses; i++)
            {
                
                Console.WriteLine("How long do you want your house to be?: ");
                double houselength = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("how thic do you want the house to be?: ");
                double houseThic = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("How high do you want your house to be?: ");
                double houseHeight = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("What kind of roof do you want the house to have?: ");
                string houseRoof = Console.ReadLine();

                Console.WriteLine("What color do you want the house to have?: ");
                string houseColor = Console.ReadLine();  
                
                Console.WriteLine("How many floors do you want the house to have?: ");
                int houseFloors = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How much does the house cost?: ");
                double housePrice = Convert.ToDouble(Console.ReadLine());

                Console.Clear();

                double houseArea = houselength * houseThic;

                Houses.Add(new House(houselength, houseThic, houseHeight, houseRoof,houseColor, houseFloors, housePrice, houseArea));

            }

            

            foreach (House house in Houses)
            {
                house.PrintHouses();
            }
            

            Console.ReadKey();

        }
    }
}

