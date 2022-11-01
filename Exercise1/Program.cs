using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine("Hello GitHub!");

            /*
             Ett litet företag i restaurangbranschen kontaktar dig för att utveckla ett litet
personalregister. De har endast två krav:
1. Registret skall kunna ta emot och lagra anställda med namn och lön. (via inmatning
i konsolen, inget krav på persistent lagring)
2. Programmet skall kunna skriva ut registret i en konsol
             */
                
            int wage = 0;
            //1. Register
            Console.WriteLine("FirstName:");
            string firstName = Console.ReadLine();
            Console.WriteLine("LastName:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Wage:");
            wage = int.Parse(Console.ReadLine());


            //Method RegisterPersonal
            
            static void RegisterPersonal (string firstName, string lastName, int wage)
            {
                Console.WriteLine("Wage {2} for {0} {1}", firstName, lastName, wage);
            }

            //2. Print register
            Console.WriteLine("Wage {2} for {0} {1}", firstName, lastName, wage);
           

        }
    }
}