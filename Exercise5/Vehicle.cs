using System;
using System.Xml.Linq;

namespace Exercise5
{
    /// <summary>
    /// Based class Vehicle Abstract (like Animal)
    /// </summary>
    public class Vehicle : AbstractVehicle
    {
        //Fields  
        protected string regNo = string.Empty; //Unique ID [AAA111] || [AAA11A]
        protected string model = string.Empty; // Model
        protected string manufacturer = string.Empty; // Manufacturer
        protected string color = string.Empty; // Color
        //private int numOfDoors; // The number of doors => Car class Only
        //private int numOfWheels; // The number of wheels => Car class Only

        public virtual string Model { get => model; set => model = value; }

        //public string RegNo { get; }
        public virtual string RegNo { get => regNo; set => regNo = value; }

        public virtual string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public virtual string Color { get => color; set => color = value; }

        public Vehicle() : this("NotRegistredYet","DefaultModel", "DefaultManufacturer" , "DefaultColor" ) { }
        public Vehicle(string regNo, string model, string manufacturer, string color, bool isInUse = false) : base(isInUse)//Constructor
        {

            //Validation?      
            RegNo = regNo;
            Model = model;
            Manufacturer = manufacturer;
            Color = color;
        }

        public override string ToString()
        {
            return $"RegNumber: {RegNo} Model: {Model}";
        }
    }
}