using System;
using System.ComponentModel;
using System.Security.Cryptography;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Util-klass for input validation
            /* https://github.com/Lexicon-Net/EmployeeList/blob/master/EmployeeList.Helpers/Util.cs*/
            //

            //Statisk klass kan ej instansieras (med andra ord EJ : Util util = new Util())
            //Statiska klasser kan endast ha statiska medlemmar
            //Anropas med klassNamn.MetodNamn tex Util.AskForString("Hej!", new ConsoleUI())

            //Util util = new Util();
            //Util.AskForString("Hej!", new UI());
           
            //Initialisation:
            //ConsoleUI + Handler  
            IUI ui = new ConsoleUI();
            Handler handler = new Handler(1); //TODO: Default Constructor shouldn't take any parameter.
            //Manager
            Manager manager = new Manager(ui, handler);
            manager.ShowMenu();
            
            
            //var man = new Manager();
            //man.SayHiManager();
            //man.ShowMenu();
            //Console.ReadKey();

        }
    }
}