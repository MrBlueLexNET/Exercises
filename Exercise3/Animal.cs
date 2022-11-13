using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    //3.3 Arv
    public abstract class Animal
    {
        protected Animal()
        {

        }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public virtual string Type { get; } = string.Empty;

        // Derived classes must implement this.
        public abstract string DoSound();

        //3.4) Mer polymorfism
        //1. Skapa metoden Stats() i klassen Animal som har returtypen string.
        //Metoden ska kunna overridas i dess Subklasser.
        //Metoden ska returnera alla egenskaper(properties) som djuret har.
        public override string ToString() => Name;
        public virtual string Stats() => $"Name: {Name} Description: {Description}";
    }
    public class Horse : Animal
    { 
    public bool IsfullBlood { get; }

        public override string DoSound()
        {
            return "Hello from Horse!";
        }

        public override string Stats()
        {
            return base.Stats() + "Full blood: " + IsfullBlood;
        }
    }
    public class Dog : Animal
    {
        private bool purebredDog;

        public bool PurebredDog
        {
            get { return purebredDog; }
            set { purebredDog = value; }
        }

        public override string DoSound()
        {
            return "Hello from Dog!";
        }

        public override string Stats()
        {
            return base.Stats() + "Pure dog: " + PurebredDog; 
        }
    }

    public class Bird : Animal
        {
            public override string DoSound()
            {
                return "Hello from Bird!";
            }
        }
        //8. Skapa nu följande tre klasser: Pelican, Flamingo och Swan.Dessa ska ärva från Bird
        public class Pelican : Bird 
        {
            private int isWhiteOrBrown;

            public int IsWhiteOrBrown //1 White || 2 Brown
            {
                get { return isWhiteOrBrown; }
                set { isWhiteOrBrown = value; }
            }
        public override string Stats()
        {
            return base.Stats() + "Color white or brown: " + IsWhiteOrBrown;
        }

    }
        public class Flamingo : Bird
        {
            private bool liveInColonies;

            public bool LiveInColonies
            {
                get { return liveInColonies; }
                set { liveInColonies = value; }
            }
        public override string Stats()
        {
            return base.Stats() + "Lives in a coloni: " + LiveInColonies;
        }   

        }
        public class Swan : Bird
        {
            private bool maried;

            public bool Maried
            {
                get { return maried; }
                set { maried = value; }
            }
        public override string Stats()
        {
              
            if (maried is true)  
            return base.Stats() + " Busy Swan!";
         return base.Stats() + " Free as a Swan!";

        }
    }
  
}
