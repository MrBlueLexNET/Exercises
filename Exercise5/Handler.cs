using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise5
{
    /// <summary>
    /// Only the Handler knows about the class Garage
    /// Most of the methods related to Garage will be define in this class Should be named GarageHandler
    /// </summary>
    public class Handler : Garage<Vehicle>
    {
        private int capacity; // Capacity
       
        protected int Capacity {

            get
            {
                return capacity;
            }
            set
            {
                if (value > 0)//capacity must be greater than 0.
                {
                    new string($"{value} The garage capacity must be greater than 0");
                }
                capacity = value;
            }
        }



        public Handler(int capacity) : base(capacity)
        {
            var garage = new Garage<Vehicle>(capacity);
        }

        public void ShowVehicles()
        {
            Console.WriteLine($"Vehicles in garage:");
            Console.WriteLine("==========================");

            //foreach (var Item in Garage<Vehicle>)
            //{
            //    Console.WriteLine("Vehicle #: {0}", Item.Model);
            //    Console.WriteLine("RegNumber:  {0}", Item.RegNo);
            //    Console.WriteLine("---------------------------");
            //}
        }

        ////Filter by [Properties] (no execution) for an int 
        //var q = garage.Where(p => p.RegNumber  = "aaa111";
        ////Sort by name (no execution)
        //q = q.OrderBy(p => p.Name);

        ////Execution
        //foreach (var item in q)
        //{ }

    }
}
