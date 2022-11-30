using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public class Airplane : Vehicle
    {
        //Fields
        private int numOfMotors; // The number of motors => Airplaine class Only

        //Properties
        public static int InstanceCount { get; internal set; }
        public int NumOfMotors { get => numOfMotors; set => numOfMotors = value; }

        public Airplane(string regNo, string model, string manufacturer, string color, int numOfMotors) : base(regNo, model, manufacturer, color)//Constructor
        {
            NumOfMotors = numOfMotors;
            InstanceCount += 1;
        }

        public override string ToString()
        {
            return $"Type:{GetType().Name} RegNumber: {RegNo} Model: {Model} NumOfMotors: {NumOfMotors} InstanceCount: {InstanceCount}";
        }


    }
}
