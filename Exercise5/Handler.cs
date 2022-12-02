using System;
using System.Collections;
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

        public bool NewGarage(int capacity)
        {
            garage = new Garage<Vehicle>(capacity);
            return true;
        }

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
            garage.Unpark(regnr);
            return true;
        }

        internal void PrintAllVehicles()
        {
            Console.WriteLine($"Vehicles in garage:");
            Console.WriteLine("==========================");
            foreach (var vehicle in garage)
            {
                Console.WriteLine("Vehicle type {1}#: {0}", vehicle.Model , vehicle.GetType().Name);
                Console.WriteLine("RegNumber:  {0}", vehicle.RegNo);
                Console.WriteLine("---------------------------");
            }

           
        }

        internal void PrintAllVehiclesGroupByType()
        {
            //No Execution
            var q = garage.Where(p => p.RegNo  == "BSM005");
            q = q.OrderBy(p => p.GetType().Name);

            //Execution
            Console.WriteLine($"Vehicles in garage: OrderByType");
            Console.WriteLine("==========================");
            foreach (var item in q)
            {
                
                Console.WriteLine("Vehicle type {1}#: {0}", item.Model, item.GetType().Name);
                Console.WriteLine("RegNumber:  {0}", item.RegNo);
                Console.WriteLine("---------------------------");

            }
        }

        internal void PrintVehiclesTypeCount()
        {
            
            var vehiculeTypes =
            from vehicle in garage
            group vehicle by vehicle.GetType().Name into vehiculeGroup
            select new
            {
                Types = vehiculeGroup.Key,
                Count = vehiculeGroup.Count(),
            };

            //Execution
            Console.WriteLine($"Vehicles in garage: TypeCount");
            Console.WriteLine("==========================");
            foreach (var item in vehiculeTypes)
            {
                Console.WriteLine("Vehicle type {0}#: {1}", item.Types, item.Count);
                Console.WriteLine("---------------------------");
            }
        }

        internal void FindVehiculeByRegNo(string regNo) 
        {
            var RegNo = regNo;
            //var result = garage.Where(v => v.RegNo == RegNo).ToList();
            var result = garage.Where(v => v.RegNo == RegNo);

            foreach (var item in result)
            {
                Console.WriteLine($"Found Model: {item.Model} with RegNo: {item.RegNo}");
                Console.WriteLine("---------------------------");
            }
        }

        internal void SearchVehiculeAllProperties(string searchParam)
        {
            var SearchParam = searchParam;
            var result = garage.Where(v => v.GetType().GetProperties().Any(p => p.GetValue(v, null) != null && p.GetValue(v, null).ToString().Contains(SearchParam)));
            //Execution
            Console.WriteLine($"Vehicles in garage: with {SearchParam}");
            Console.WriteLine("==========================");
            foreach (var item in result)
            {
                    //item.GetType().GetProperties().Any()//True
                    Console.WriteLine($"Properties found for Model: {item.Model} with RegNo: {item.RegNo}");
                    Console.WriteLine("---------------------------");
                    //else
                    //Console.WriteLine($"No vehicule found");
                    //Console.WriteLine("---------------------------");
            }
        }

    }
}
