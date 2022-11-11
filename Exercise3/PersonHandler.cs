using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class PersonHandler : Person
    {
        //public PersonHandler(string fname, string lname ) : base() // Constructor using base class
        //{ 
        //}
        //private string fname;
        //private string lname;
        private double bmi;
       
        public double Bmi { get => bmi; }
        //public string Fname { get => fname; set => fname = value; }
        //public string Lname { get => lname; set => lname = value; }

        //double bmi = height / ((weight / 100.0) * (weight / 100.0));

        //3.2
        public void SetAge(Person pers, int age)//Use protected field age in base class
        { 
            pers.Age = age;
        }
        //3.3
        //public Person CreatePerson(string fname, string lname)
        //{
        //    Fname = fname;
        //    Lname = lname;
        //}
        ////abstract method need to have the Class use what?
       
        //3.2
        //New Methods
        public void SetWeight(Person pers, double weight)
        { 
        pers.Weight = weight;

        }
        public void SetHeight(Person pers, double height)
        { 
        pers.Height = height;
        }
        public double BMI(double weight, double height)
        {
            bmi = height / ((weight / 100.0) * (weight / 100.0));
            return bmi;
        }   
    }
}
