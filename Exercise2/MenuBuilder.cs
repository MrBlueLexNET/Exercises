using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
   //ToDo: Building Menu instances based on a Class 
    public class MenuBuilder
    {
        public const string headerText = ("Start");
        public const string option1Text = ("Ungdom eller pensionär");
        public const string option2Text = ("Upprepa tio gånger");
        public const string option3Text = ("Det tredje ordet");
        public const string footerText = ("End...");

        private int menuoption;
        private string menulang;

        private uint option;

        public int Menuoption
        {
            get { return menuoption; }
            set
            {

                //  menuoption = value < 0 ? 0 : value;

                if (menuoption < 0)
                {
                    menuoption = 0;
                }
                else
                {
                    menuoption = value;
                }
            }
        }

        public uint Option { get => option; set => option = value; }
        public string Menulang { get => menulang; set => menulang = value; }

        //Konstruktor med parametrar
        //En konstruktor har aldrig någon retur typ och heter samma sak som klassen
        //Konstruktorn körs direkt när man skapar ett ny instans av klassen med nyckelordet new
        //Tex MenuBuilder menu = new MenuBuilder("eng",1);
        //Nu måste vi alltid skicka med ett lang och option för att få skapa en ny menu
        public MenuBuilder(string menulang, int menuoption)
        {
            //Validate
            this.menulang = menulang;
            this.menuoption = menuoption;
        }

        public void ShowMainMeny()
        {
            Console.WriteLine($"{MenuBuilder.headerText}.");
            Console.WriteLine($"{MenuBuilder.option1Text}.");
            Console.WriteLine($"{MenuBuilder.option2Text}.");
            Console.WriteLine($"{MenuBuilder.option3Text}.");
            Console.WriteLine($"{MenuBuilder.footerText}.");

            Console.WriteLine("Choose the option you want to perform:");
            uint Option = uint.Parse(Console.ReadLine()!);
            Console.WriteLine($"You choose option {Option}");
        }
    }
}
