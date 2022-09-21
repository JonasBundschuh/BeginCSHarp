using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Markup;

namespace Filehandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //erste zahl bekommen
            Console.WriteLine("Sage deine erste zahl: ");
            double z1 = Convert.ToDouble(Console.ReadLine());
            
            //zweite zahl bekommen
            Console.WriteLine("Sage deine zweite Zahl: ");
            double z2 = Convert.ToDouble(Console.ReadLine());   

            //operator bekommen
            Console.WriteLine("Wähle deinen Operator: ");
            char op = Convert.ToChar(Console.ReadLine());

            //ergebnisse speichern
            double ergebnisDiv = ErgebnisRechnung(z1, z2, op);
            double ergebnisMu = ErgebnisRechnung(z1, z2, op);
            double ergebnisMi = ErgebnisRechnung(z1, z2, op);
            double ergebnisPl = ErgebnisRechnung(z1, z2, op);

             if (op == '/')
            {
                Console.Clear();
                Console.WriteLine(ergebnisDiv);
            }
             else if (op == '*')
            {
                Console.Clear();
                Console.WriteLine(ergebnisMu);
            }
             else if (op == '+')
            {
                Console.Clear();
                Console.WriteLine(ergebnisPl);
            }else if (op == '-')
            {
                Console.Clear();
                Console.WriteLine(ergebnisMi);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("not a valid operator");
            }
            Console.ReadLine();
        } 

        static double ErgebnisRechnung(double z1, double z2, char op)
        {
           
            switch (op)
            {
                case '/':
                    double ergebnisDivide = z1 / z2;
                    return ergebnisDivide;
                    break;
                case '*':
                    double ergebnisMulti = z1 * z2;
                    return ergebnisMulti;
                    break;
                case '+':
                    double ergebnisAdd = z1 + z2;
                    return ergebnisAdd;
                    break;
                case '-':
                    double ergebnisSub = z1 - z2;
                    return ergebnisSub;
                    break;
                

            }
            return 0; 


            
        }



    }

}