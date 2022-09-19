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

            Console.WriteLine("How many cars would u like to add?: ");
            int AmountCars = Convert.ToInt32(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < AmountCars; i++)
            {
                Console.WriteLine("What TypeID do you want the car to have?: ");
                int vehicleID = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What brand do you want the car to be off?: ");
                string vehicleMake = Console.ReadLine();

                Console.WriteLine("What model do you want the car to be?: ");
                string vehicleModel = Console.ReadLine();

                Console.WriteLine("What type do you want the car to be?: ");
                string vehicleType = Console.ReadLine();

                Console.WriteLine("How much ccm do you want the car to have?: ");
                int vehicleCmm = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How many tyres do you want the car to have?:");
                int vehicleTyres = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What color do you want the car to be?: ");
                string vehicleColor = Console.ReadLine();

                Console.Clear();

                cars.Add(new Car(vehicleID, vehicleType, vehicleMake, vehicleModel, vehicleCmm, vehicleTyres, vehicleColor));
            }

            foreach (Car car in cars)
            {
                car.PrintCarInformation();
            }

            Console.ReadKey();

        }
    }
}

