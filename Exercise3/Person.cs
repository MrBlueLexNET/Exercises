using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Person
    {
        //Constructor default
        //TOREAD: Constructors (C# programming guide)
        public Person()
        {
            this.fName = string.Empty;
            this.lName = string.Empty;
            this.fullName = string.Empty;
        }
        //Constructor
        public Person(int age, string fName, string lName, double height, double weight)
        {

            FName = fName;
            LName = lName;
            Age = age;
            Height = height;
            Weight = weight;
        }
        //Private Fields: fName, lName, height, weight
        //private string fName;
        //private string lName;
        private string fullName = string.Empty;


        //Protected Fields to be used for classes that are related to Person
        protected string fName = string.Empty;
        protected string lName = string.Empty;

        protected int age;
        protected double height;
        protected double weight;


        //public int Age { get => age; set => age = value; }//Full-Properties with accessor get and set 
        public int Age { 
            get { 
                return age; 
            } 
            set {
                if (value > 0)//Age kan bara tilldelas ett värde större än 0.

                {
                    new string ($"{value} is not greater than 0."); 
                }
                age = value;
            } 
        }
        public string FName { 
            get { return fName; } 
            set { 
                if (string.IsNullOrEmpty(value) || (value.Length < 2 || value.Length > 10)) //Obligatorisk och får inte vara mindre än 2 tecken eller längre än 10 tecken.
                { 
                    Console.WriteLine($"{value} The valid range is between 2 and 10 characters.");
                    throw new ArgumentException(); //ArgumentException
                }
                fName = value;

            } 
        }
        public string LName { 
            get { return lName; }
            set { 
                
                if (string.IsNullOrEmpty(value) || (value.Length < 3 || value.Length > 15))
                {
                    Console.WriteLine($"{value} The valid range is between 3 and 15 characters.");
                    throw new ArgumentException(); //ArgumentException
                }
                lName = value;
            
            }
            
        }

        public string FullName
        {
            get { return FName + " " + LName; }
           
        }

        public double Weight { get => weight; set => weight = value; }
        public double Height { get => height; set => height = value; }

        //Override ToString Method from Base class Object return FullName for the Person class 
        public override string ToString() => FullName;

        //Validate Method
        public bool Validate()
        { 
        var isValid = true;
            if (string.IsNullOrWhiteSpace(FName) && string.IsNullOrWhiteSpace(LName))//Validation fields 
                    { isValid = false; }
        return isValid;
        }
        //SetAge Method
        //public virtual void SetAge(Person pers, int age)
        //{
        //}
        //CreatePerson Method
        //public virtual void CreatePerson()
        //{ }
        




    }

}
