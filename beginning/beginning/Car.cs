using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace beginning
{
    public class House
    {
        public double length { get; set; }
        public double thicness { get; set; }
        public double height { get; set; }
        public string roof { get; set; }
        public string color { get; set; }
        public int floors { get; set; }
        public double price { get; set; }
        public double area { get; set; }


      public House(double length, double thicness, double height, string roof, string color, int floors, double price, double area)
        {
            this.length = length;


            this.thicness = thicness;
            this.height = height;
            this.roof = roof;
            this.color = color;
            this.floors = floors;
            this.price = price;
            this.area = area;
        }

        public void PrintHouses()
        {
            Console.WriteLine($"The house has a length of {length}, a thicnes of {thicness}, and a height of {height}.Its on a area of {area}. It has a {roof} roof and its color is {color} and it has {floors} floors. The house costs ${price}");
        }

        

    }

}
