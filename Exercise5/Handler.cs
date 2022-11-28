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
    public class Handler /*: Garage<Vehicle>*/
    {
        private int capacity; // Capacity

        private Garage<Vehicle> garage;

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

        

        public Handler(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
        }

        
        ////Filter by [Properties] (no execution) for an int 
        //var q = garage.Where(p => p.RegNumber  = "aaa111";
        ////Sort by name (no execution)
        //q = q.OrderBy(p => p.Name);

        ////Execution
        //foreach (var item in q)
        //{ }

        //********************************
        //Method For Menu selection 2:  Add vehicles without any garage initialized
        //********************************
        public bool AddVehiclesNoGarage()
        {
            //ToDo:
            return true;
        }
        //********************************
        //Methods For Menu selection 2: Add[+] and Remove[-] vehicles from the garage:
        //********************************
        public bool AddVehicles(Vehicle newVehicle)
        {
            //ToDo:
            garage.Park(newVehicle);
            return true;
        }
        public bool DelVehicles(string regnr)
        {
            //ToDo:
            //UnPark(new <Vehicle>)
            return true;
        }

        internal void PrintAllVehicles()
        {
            Console.WriteLine($"Vehicles in garage:");
            Console.WriteLine("==========================");
            foreach (var vehicle in garage)
            {
                Console.WriteLine("Vehicle #: {0}", vehicle.Model);
                Console.WriteLine("RegNumber:  {0}", vehicle.RegNo);
                Console.WriteLine("---------------------------");
            }

            //var test3 = garage.Where(v => v.Model == "V90").ToList();
        }
    }
}
