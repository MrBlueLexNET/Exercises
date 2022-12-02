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
        private readonly IUI ui;
        private readonly Handler handler;

        public Manager(IUI ui, Handler handler)
        {
            this.ui = ui;
            this.handler = handler;

        }
        //public void SayHiManager()
        //{
        // Console.WriteLine("HI from the Manager class");
        // Console.Clear();
        //}
        
        public void ShowMenu()//public
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
                Console.WriteLine("[2]Populate the garage with a number of vehicles from the start [SeedData()]:");
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
                    case "2":
                        SeedData();
                        ShowSubMenu();
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

            } while (true);
        }

        public void ShowSubMenu()
        {
            
            do
            {
                Console.WriteLine("-----------------------------------\n");
                Console.WriteLine("Sub Menu selection\n\r");
                Console.WriteLine("-----------------------------------\n");
                Console.WriteLine("[0]Return to main menu:");
                Console.WriteLine("[-]Remove vehicles from the garage:");
                Console.WriteLine("[1]List all parked vehicles:");
                Console.WriteLine("[2]List vehicle types and how many of each are in the garage:");
                Console.WriteLine("-----------------------------------\n");
                Console.WriteLine("[3]Find a specific vehicle via the registration number:");
                Console.WriteLine("[4]Free search: using [*:All] [KeyWords] [&:And] [|:Or]");
                Console.WriteLine("-----------------------------------\n");

                string input = Console.ReadLine()!;

                switch (input)
                {
                    case "0":
                        Console.Clear();
                        ShowMenu();
                        break;
                    case "-":
                        Selection00();
                        break;
                    case "1":
                        Selection01();
                        break;
                    case "2":
                        Selection02();
                        break;
                    case "3":
                        Selection03();
                        break;
                    case "4":
                        Selection04();
                        break;

                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

            } while (true);
        }
        private void AddVehicule(Handler handler, string type)
        {
            //Console.Clear();
            //********************************
            //Menu selection 2:  Add vehicles
            //********************************
            Console.WriteLine("-----------------------------------\n");
            Console.WriteLine($"Menu selection 1:2  Vehicle {type}\r\n");
            Console.WriteLine("-----------------------------------\n");

            string regNo = Util.AskForStringRegNo("RegNo", ui);
            string model = Util.AskForString("Model", ui);
            string manufacturer = Util.AskForString("Manufacturer", ui);
            string color = Util.AskForString("Color", ui);

            if (type == "Car")
            {
                int numOfDoors = Util.AskForInt("NumOfDoors", ui);
                int numOfWheels = Util.AskForInt("NumOfWheels", ui);
                var newcar = new Car(regNo, model, manufacturer, color, numOfDoors, numOfWheels);
                handler.AddVehicles(newcar);
            }
            if (type == "Bus")
            {
                int numOfSeats = Util.AskForInt("NumOfSeats", ui);
                var newbus = new Bus(regNo, model, manufacturer, color, numOfSeats);
                handler.AddVehicles(newbus);
            }
            if (type == "Airplane")
            {
                int numOfMotors = Util.AskForInt("NumOfMotors", ui);
                var newairplane = new Airplane(regNo, model, manufacturer, color, numOfMotors);
                handler.AddVehicles(newairplane);
            }

            if (true)
            {
                Console.WriteLine("==========================");
                Console.WriteLine($"Vehicule created Type: {type}");
                Console.WriteLine("==========================");
            }
            Console.ReadKey();
            //Console.Clear();

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
            //Console.Clear();
            if (true)
            {
                Console.WriteLine("==========================");
                Console.WriteLine($"Garage created for: {capacity} vehicles.");
                Console.WriteLine("==========================");
            }
            //********************************
            //Menu selection 1:1  Park
            //********************************
            //Console.Clear();
            //1. Select Type based on class names
            
            for (int i = 0; i < capacity; i++)
               
            {   
                Console.WriteLine("Select vehicule type:");
                Console.WriteLine("[1]Car | [2]Bus | [3]Airplane");
                Console.WriteLine("---------------------------");
                int type = Util.AskForInt("Type", ui);
                switch (type)
                {
                case 0:
                    Console.Clear();
                    break;
                case 1:
                    //<T> Car
                    string vehiculetypeCar = "Car";
                    AddVehicule(handler, vehiculetypeCar);
                    //handler.AddVehicles(new Car("JMY066", "V50", "Volvo", "Flamigo Red", 4, 2));
                    Console.WriteLine("New Car parked in garage");
                    Console.WriteLine("---------------------------");
                        break;
                case 2:
                    //<T> Bus
                    string vehiculetypeBus = "Bus";
                    AddVehicule(handler, vehiculetypeBus);
                    //
                    Console.WriteLine("New Bus parked in garage");
                    Console.WriteLine("---------------------------");
                        break;
                case 3:
                     //<T> Airplane
                     string vehiculetypeAirplane = "Airplane";
                     AddVehicule(handler, vehiculetypeAirplane);
                     //AddVehicule(Handler handler, srting type);
                     
                     Console.WriteLine("New Airplain parked in garage");
                     Console.WriteLine("---------------------------");
                        break;

                    default:
                    Console.WriteLine("Wrong input");
                    Console.WriteLine("---------------------------");
                        i--;
                    break;
                }
            }
            ShowSubMenu();
          

            Console.ReadKey();
            Console.Clear();

        }

        private void Selection00()
        {
            //********************************
            //SubMenu selection 2:00  Unpark
            //********************************
            //Console.Clear();
            string regNo = Util.AskForStringRegNo("RegNo", ui);
            handler.DelVehicles(regNo);
        }

        private void Selection01()
        {
            //********************************
            //SubMenu selection 2:01  List all parked vehicles:
            //********************************
            //Console.Clear();
            //PrintAllVehicles Method
            handler.PrintAllVehicles();
        }
        private void Selection02()
        {
            //********************************
            //SubMenu selection 2:02  List vehicle types and how many of each are in the garage:
            //********************************
            //Console.Clear();
            //PrintAllVehiclesGroupByType Method
            handler.PrintAllVehiclesGroupByType();

            //PrintVehiclesTypeCount Method
            handler.PrintVehiclesTypeCount();
        }
       
        private void Selection03()
        {
            //********************************
            //SubMenu selection 2:03  Find a specific vehicle via the registration number:
            //********************************
            //Console.Clear();
            //FindVehiculeByRegNo Method with 1 parameter
            string Id = Util.AskForStringRegNo("RegNo", ui);
            handler.FindVehiculeByRegNo(Id);
        }

        private void Selection04()
        {
            //********************************
            //SubMenu selection 2:04  Free search: using [*:All] [KeyWords] [&:And] [|:Or]:
            //********************************
            //Console.Clear();
            //SearchVehiculeAllProperties Method with 1 parameter
            string searchprop = Util.AskForString("Search for properties", ui);
            handler.SearchVehiculeAllProperties(searchprop);
        }

        public void SeedData()
        {
            handler.NewGarage(8);
            //AddVehicles Method for SeedData method
            handler.AddVehicles(new Car("JMY066", "V50", "Volvo", "Flamigo Red", 4, 2));
            handler.AddVehicles(new Car("LEM008", "V90", "Volvo", "Black", 4, 2));
            handler.AddVehicles(new Car("ESM005", "V60", "Volvo", "Pink", 4, 2));
            handler.AddVehicles(new Bus("BSM005", "B55", "Volvo", "White", 55));
            handler.AddVehicles(new Car("BSM005", "V90", "Volvo", "White", 4, 2));
            handler.AddVehicles(new Bus("BSM005", "B55", "Volvo", "Yellow", 55));
            handler.AddVehicles(new Airplane("APP001", "B-52", "Boeing", "Grey", 8));
            handler.AddVehicles(new Bus("BSG005", "Citywide Low Entry gas", "Scania", "White", 55));

            //Demo start
            //ShowSubMenu();
            //return handler; 
        }

    }
}

