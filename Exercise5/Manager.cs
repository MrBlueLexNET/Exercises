using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Manager
    {

        public void SayHiManager()
        {
            Console.WriteLine("HI from the Manager class");
            Console.Clear();
        }
        
        internal void ShowMenu()
        {
            //TODO seed Garage instance with Objects
            //SeedData();
            //

            do
            {
                Console.WriteLine("-----------------------------------\n");
                Console.WriteLine("Menu selection\n\r");
                Console.WriteLine("-----------------------------------\n");
                Console.WriteLine("[0]Quit:");
                Console.WriteLine("[1]Putting a capacity (number of parking spaces) when instantiating a new garage [Create]:||[11]Grupp?");
                Console.WriteLine("[2]Populate the garage with a number of vehicles from the start [Add]:");
                Console.WriteLine("[3]Add[+] and Remove[-] vehicles from the garage:");
                Console.WriteLine("[4]List all parked vehicles:");
                Console.WriteLine("[5]List vehicle types and how many of each are in the garage:");
                Console.WriteLine("-----------------------------------\n");
                Console.WriteLine("[6]Find a specific vehicle via the registration number:");
                Console.WriteLine("[7]Free search: using [*:All] [KeyWords] [&:And] [|:Or]");
                Console.WriteLine("-----------------------------------\n");

                string input = Console.ReadLine()!;

                switch (input)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        Selection1();
                        //Menyval11();
                        break;
                    case "11":
                        //Menyval11();
                        break;
                    case "2":
                        Selection2();
                        break;
                    case "3":
                        //Menyval3();
                        break;

                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

            } while (true);
        }

        static void Selection1()
        {
            //********************************
            //Menu selection 1:  New garage
            //********************************
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("Menu selection 1:  New garage\r\n");
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("Garage capacity?");
            var inputCapacity = Console.ReadLine()!;

            int capacity = UInt16.Parse(inputCapacity);
            /***************************/
            /*Handler*/
            /***************************/
            var garage = new Handler(capacity);
            garage.Park(new Car("JMY066", "V50", "Volvo", "Flamigo Red", 4, 2));
            garage.Park( new Car("LEM008", "V90", "Volvo", "Black", 4, 2));
            garage.Park(new Car("ESM005", "V60", "Volvo", "Pink", 4, 2));

            garage.Unpark("JMY066");

            foreach (var vehicle in garage)
            {
                Console.WriteLine(vehicle.ToString());
            }

            //LINQ ex.
            var test1 = garage.Any();
            var test2 = garage.Any(v => v.RegNo == "LEM008");
            var test3 = garage.Where(v => v.Model == "V90").ToList();

            Console.WriteLine(test1);
            Console.WriteLine(test2);
            Console.WriteLine(test3.Count);
            Console.WriteLine(test3);

            garage.ShowVehicles();


            Console.ReadKey();


        }

        static void Selection2()
        {
            //********************************
            //Menu selection 2:  Add vehicles
            //********************************
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("Menu selection 2:  Vehicles\r\n");
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("Unique Id?");
            if (Console.CapsLock)
            {
                var inputId = Console.ReadLine()!;
            }
            else
            {
                Console.WriteLine("Capital letters for Ids");
            }

            Console.ReadKey();
        }
        
        //private void SeedData()
        //{
        //    /***************************/
        //    /*GenericGarage*/
        //    /***************************/
        //    GenericGarage<Car> genericGarageCity = new GenericGarage<Car>("Generic City Garage", 5);
        //    /***************************/
        //    /*Generic City Garage*/
        //    //Vehicle[5]
        //    /***************************/
        //    var car01 = new Car("JMY066", "V50", "Volvo", "Flamigo Red", 4, 2);
        //    //genericGarageCity.vehicles[0] = car01;
                
            
        //}


        
    }
}

