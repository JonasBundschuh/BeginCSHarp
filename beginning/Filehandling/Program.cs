using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Filehandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int azubiAnzahl = 4;

            List<string> myTrainees = CreateAzubiNameList(azubiAnzahl);
            List<string> myTraineesWithM = GiveMeTraineesWithM(myTrainees);
            foreach(string trine in myTraineesWithM) 
            { 
                Console.Clear();
                Console.WriteLine(trine);
            }
            Console.ReadLine();

        }

        static List<string> CreateAzubiNameList(int p_azubi)
        {
            Console.WriteLine("Gebe die namen der azubis an");
            List<string> azubiNamen = new List<string>();
            while (azubiNamen.Count < p_azubi)
            {
                azubiNamen.Add(Console.ReadLine());
            }

            return azubiNamen;
        }

        static List<string> GiveMeTraineesWithM(List<string> allTrainees)
        {
            List<string> traineesWithM = new List<string>();
            foreach (string t in allTrainees)
            {
                if (t.StartsWith("m")){
                    traineesWithM.Add(t);
                }
                
            }
            return traineesWithM;
            


        }

       
    }
    
}
