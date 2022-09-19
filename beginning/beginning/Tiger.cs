using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{ 
    internal class Tiger : Animals 
    {

        public Tiger (string namen, string tierart, int alter, double groesse, int lebensdauer, int gewicht, bool fell, bool trinken, bool essen, string geraeusch)
        {
            Namen = namen;
            Tierart = tierart;
            Alter = alter;
            Groesse = groesse;
            Lebensdauer = lebensdauer;
            Gewicht = gewicht;
            Fell = fell;
            Trinken = trinken;
            Essen = essen;
            Geraeusch = geraeusch;
        }

        public override void Geraeusche()
        {
            Console.WriteLine($"{this.GetType().Name} macht {Geraeusch}");   
        }
    }
}
