using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise5
{
    /// <summary>
    /// Based class Vehicle for Car
    /// </summary>
    public class Car : Vehicle
    {
        //Fields
        private int numOfDoors; // The number of doors
        private int numOfWheels; // The number of wheels

        //Properties
        public static int InstanceCount { get; internal set; }
        public int NumOfDoors { get => numOfDoors; set => numOfDoors = value; }
        public int NumOfWheels { get => numOfWheels; set => numOfWheels = value; }

        public Car(string regNo, string model, string manufacturer, string color, int numOfDoors, int numOfWheels) : base(regNo, model, manufacturer, color)//Constructor
        {
            //Validation?
            /*Manufacturer = manufacturer;*///private in the base class
            NumOfDoors = numOfDoors;
            NumOfWheels = numOfWheels;
        }

        public override string ToString()
        {
            return $"{GetType().Name} RegNumber: {RegNo} Model: {Model} NumOfDoors: {NumOfDoors} NumOfWheels: {NumOfWheels} ";
        }
    }
}
