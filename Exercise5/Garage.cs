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
    //public class Garage<T> : IEnumerable<T>
    //{
    //    //Properties
    //    public string Name { get; }
    //    public uint Capacity { get; }

    //    //Fields
    //    private readonly Array[] vehicles;//https://www.functionx.com/csharp40/arrays/Lesson03.htm


    //    public Array[] Vehicles
    //    {
    //        get { return vehicles; }
    //       // set { vehicles = value; }
    //    }



    //    //Constructor
    //    public Garage(string name, uint capacity)
    //    {
    //        //Validation?
    //        Name = name;
    //        Capacity = capacity;
    //    }

    //    public override string ToString()
    //    {
    //        return $"Name: {Name} Capacity: {Capacity}";
    //    }
    //    //Extra Field
    //    private IEnumerable<T> _wrapped;

    //    //Constructor
    //    public Garage(IEnumerable<T> wrapped, uint capacity)
    //    {
    //        _wrapped = wrapped;
    //        Capacity = capacity;
    //    }

    //    // This method returns an IEnumerator<T>, rather than an IEnumerable<T>
    //    // But the yield syntax and usage is identical.
    //    public IEnumerator<T> GetEnumerator()
    //    {
    //        foreach (var item in _wrapped)
    //        {
    //            Console.WriteLine("Yielding: " + item);
    //            yield return item;
    //        }
    //    }

    //    IEnumerator IEnumerable.GetEnumerator()
    //    {
    //        return GetEnumerator();
    //    }

    //    public override bool Equals(object? obj)
    //    {
    //        return obj is Garage<T> garage &&
    //               Capacity == garage.Capacity;
    //    }



    //}
}
