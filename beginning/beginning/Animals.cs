using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    public abstract class Animals
    {
       public string Namen { get; set; }
        public string Tierart { get; set; }
        public int Alter { get; set; }
        public double Groesse { get; set; }
        public int Lebensdauer { get; set; }
        public int Gewicht { get; set; }
        public bool Fell { get; set; }
        public bool Trinken { get; set; }
        public bool Essen { get; set; }
        public string Geraeusch { get; set; }

        public void PrintAnimal()
        {
            Console.WriteLine($"Der {this.GetType().Name} heißt {Namen}.");
        }

        public abstract void Geraeusche();
    }




    


}
