using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercise5
{
    /// <summary>
    /// Based class Garage
    /// </summary>
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {

        private T[] vehicles;

        public Garage(int capacity)
        {
            vehicles = new T[capacity];
        }

        public bool Park(T newVehicle)
        {
            for (var i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] is null)
                {
                    vehicles[i] = newVehicle;
                    return true;
                }
            }
            return false;
        }

        public bool Unpark(string regnr)
        {
            for (var i = 0; i < vehicles.Length; i++)
            {
                if (vehicles[i] is not null && vehicles[i].RegNo == regnr)
                {
                    vehicles[i] = null;
                    //vehicles[i] = default!;
                    return true;
                }
            }
            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in vehicles)
            {
                if (vehicle is not null)
                {
                    yield return vehicle;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
