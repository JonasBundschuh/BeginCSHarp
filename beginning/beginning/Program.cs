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

            Dreieck d = new Dreieck(2, 4, 10);

            Circle c = new Circle(5);
            c.Radius = 5;            

            Rechteck r = new Rechteck(10, 20);
           

            List<IGeometry> geometries = new List<IGeometry>();
            geometries.Add(d);
            geometries.Add(c);
            geometries.Add(r);

            foreach(IGeometry g in geometries)
            {
                Console.WriteLine($"mein {d.GetType().Name} hat eine fläche von {g.Flaeche()} und einen Umfang von {g.Umfang()}");
            }

            List <Vehicle> fahrzeuge = new List<Vehicle>();
            fahrzeuge.Add(new Motorcycle(532, "BMW", "GSXR 2000", "3.0", 3000, "Blau", 2));
            fahrzeuge.Add(new Car(123, "VW", "Golf V", "2.0 TDI", 1900, "Rot", 4));

            foreach(Vehicle v in fahrzeuge)
            {
                v.Starten();
                v.Beschleunigen();
                v.Bremsen();
                v.Starten();
                v.Bremsen();
                v.Bremsen();
            }


            Console.ReadLine();

        }
    }
}

