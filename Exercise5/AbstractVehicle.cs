using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
    public abstract class AbstractVehicle
    {
        protected bool isInUse;

        public AbstractVehicle(bool isInUse)
        {
            this.isInUse = isInUse;
        }

        protected void Test()
        {
            Console.WriteLine("Test");
        }
    }
}
