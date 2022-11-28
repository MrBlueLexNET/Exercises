using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Bus : Vehicle
    {
        private int numOfSeats; // The number of seats => Bus class Only
        public static int InstanceCount { get; internal set; }
        public int NumOfSeats { get => numOfSeats; set => numOfSeats = value; }

        public Bus(string regNo, string model, string manufacturer, string color, int numOfSeats ) : base(regNo, model, manufacturer, color)//Constructor
        {

            NumOfSeats = numOfSeats;
        }


    }
}
