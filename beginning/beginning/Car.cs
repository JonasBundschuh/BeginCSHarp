using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    public class Car
    {
        public int TypeId { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public string TypeName { get; set; }
        public int ccm { get; set; }
        public int TyreAmount { get; set; }
        public string color { get; set; }


        public Car(int typeId, string make, string model, string typeName, int ccm, int tyreAmount, string color)
        {
            TypeId = typeId;
            this.make = make;
            this.model = model;
            TypeName = typeName;
            this.ccm = ccm;
            TyreAmount = tyreAmount;
            this.color = color;
        }

        public void PrintCarInformation()

        {
            Console.WriteLine($"Car with the Type ID {TypeId}, made by {make} as model {model} with the Type {TypeName} and a CCM of {ccm}. It has a tire amount of {TyreAmount} and the color {color}");
        }



    }

}
