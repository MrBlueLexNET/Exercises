using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Manager
    {
        private readonly IUI ui;//TEST01
        private readonly Handler handler;

        public Manager(IUI ui, Handler handler)//TEST01 CONSTRUCTOR
        {
            this.ui = ui;
            this.handler = handler;

        }
        public void SayHiManager()
        {
            Console.WriteLine("HI from the Manager class");
            Console.Clear();
        }
        
        public void ShowMenu()
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
                Console.WriteLine("[1]Putting a capacity (number of parking spaces) when instantiating a new garage [Create]");
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
                        break;
                    case "11":
                        //Selection11();
                        break;
                    case "2":
                        //Selection2();
                        break;
                    case "3":
                        //Selection3();
                        AddVehicule();
                        break;

                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

            } while (true);
        }

        private void AddVehicule()//TEST01
        {
            Console.Clear();
            //********************************
            //Menu selection 2:  Add vehicles
            //********************************
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("Menu selection 2:  Vehicles\r\n");
            Console.WriteLine("-----------------------------------\n");

            string regNo = Util.AskForStringRegNo("RegNo", ui);
            string model = Util.AskForString("Model", ui);
            string manufacturer = Util.AskForString("Manufacturer", ui);
            string color = Util.AskForString("Color", ui);
            int numOfDoors = Util.AskForInt("NumOfDoors", ui);
            int numOfWheels = Util.AskForInt("NumOfWheels", ui);

            var tempHandler = new Handler(1);
            tempHandler.AddVehicles(new Car(regNo, model, manufacturer, color, numOfDoors, numOfWheels));

           
            if (true)
            {
                Console.WriteLine("==========================");
                Console.WriteLine($"Vehicule created Type:{GetType().Name}");
                Console.WriteLine("==========================");
            }
            Console.ReadKey();
            Console.Clear();

        }
        private void Selection1()
        {
            Console.Clear();
            //********************************
            //Menu selection 1:  New garage
            //********************************
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine("Menu selection 1:  New garage\r\n");
            Console.WriteLine("-----------------------------------\n");

            Console.WriteLine("Garage capacity?");
            //var inputCapacity = Console.ReadLine()!;
            //int capacity = UInt16.Parse(inputCapacity);
            int capacity = Util.AskForInt("Capacity", ui);
            /***************************/
            /*Handler*/
            /***************************/
            var handler = new Handler(capacity);
            Console.Clear();
            if (true)
            {
                Console.WriteLine("==========================");
                Console.WriteLine($"Garage created for: {capacity} vehicles.");
                Console.WriteLine("==========================");
            }
            //********************************
            //Menu selection 1:1  Add Vehicles
            //********************************
            //Console.Clear();
            //1. Select Type based on class names
            Console.WriteLine("Select vehicule type:");
            Console.WriteLine("[1]Car | [2]Bus | [2]Airplane");
            for (int i = 0; i < capacity; i++)
               
            {
                int type = Util.AskForInt("Type", ui);
                switch (type)
                {
                case 0:
                    Console.Clear();
                    break;
                case 1:
                    //<T> Car
                    handler.AddVehicles(new Car("JMY066", "V50", "Volvo", "Flamigo Red", 4, 2));
                    Console.WriteLine("New Car created");
                    break;
                case 2:
                    //<T> Bus
                    handler.AddVehicles(new Bus("BSM005", "B55", "Volvo", "White", 55));

                    Console.WriteLine("New Bus created");
                    break;
                case 3:
                    //<T> Airplane
                    //AddVehicule(string handler, srting type);
                    break;

                    default:
                    Console.WriteLine("Wrong input");
                    Console.WriteLine("---------------------------");
                    break;
                }
            }

            //********************************
            //Menu selection 2:2  Remove Vehicles
            //********************************
            //Console.Clear();
            //1. RegNo (Id) to remove
            string regNo = Util.AskForStringRegNo("RegNo", ui);
            //DelVehicles Method
            handler.DelVehicles(regNo);

           //DelVehicles Method
           //handler.DelVehicles("JMY066");

            //PrintAllVehicles Method
            handler.PrintAllVehicles();

            //PrintAllVehiclesGroupByType Method
            handler.PrintAllVehiclesGroupByType();

            //PrintVehiclesTypeCount Method
            handler.PrintVehiclesTypeCount();

            //FindVehiculeByRegNo Method with 1 parameter
            string Id = Util.AskForStringRegNo("RegNo", ui);
            handler.FindVehiculeByRegNo(Id);

            //SearchVehiculeAllProperties Method with 1 parameter
            string searchprop = Util.AskForString("Search for properties", ui);
            handler.SearchVehiculeAllProperties(searchprop);
            
            //LINQ ex.
            //var array = new Vehicle[10];
            //var test1 = array.Any(v => v is not null);
            //var test2 = handler.Any(v => v.RegNo == "LEM008");
            //var test3 = handler.Where(v => v.Model == "V90").ToList();
            //Console.WriteLine(test1);
            //Console.WriteLine(test2);
            //Console.WriteLine(test3.Count);
            //Console.WriteLine(test3);

            Console.ReadKey();
            Console.Clear();

        }
        //AddVehicles Method for SeedData method
        //handler.AddVehicles(new Car("JMY066", "V50", "Volvo", "Flamigo Red", 4, 2));
        //handler.AddVehicles(new Car("LEM008", "V90", "Volvo", "Black", 4, 2));
        //handler.AddVehicles(new Car("ESM005", "V60", "Volvo", "Pink", 4, 2));
        //handler.AddVehicles(new Bus("BSM005", "B55", "Volvo", "White", 55));
        //handler.AddVehicles(new Car("BSM005", "V90", "Volvo", "White", 4, 2));
        //handler.AddVehicles(new Bus("BSM005", "B55", "Volvo", "Yellow", 55));

    }
}

