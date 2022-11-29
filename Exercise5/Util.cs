using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise5 //.Helpers 
{

        //Statisk klass kan ej instansieras (med andra ord EJ : Util util = new Util())
        //Statiska klasser kan endast ha statiska medlemmar
        //Anropas med klassNamn.MetodNamn tex Util.AskForString("Hej!", new ConsoleUI())
        public static class Util
        {
            //Prompt = det vi vill skriva ut på skärmen
            //IUI hanterar input/output
            //Här har vi ingen aning vilken typ av ui som vi faktiskt jobbar med (vilken implementation) det enda vi vet är att vi kan anropa GetInput samt Print
            public static string AskForString(string prompt, IUI ui)
            {
                string answer;
                bool success = false;

                //loopa tills användaren har skrivit in något
                do
                {
                    ui.Print($"{prompt}: ");
                    answer = ui.GetInput()!;

                    //Än så länge ingen annan validering än att strängen inte får vara tom.
                    if (string.IsNullOrWhiteSpace(answer))
                    {
                        ui.Print($"You must enter a valid {prompt}");
                    }
                    else
                    {
                        success = true;
                    }

                } while (!success);

                return answer;
            }

        public static string AskForStringRegNo(string prompt, IUI ui)
        {
            string answer;
            bool success = false;


            //loopa tills användaren har skrivit in något
            do
            {
                ui.Print($"{prompt}: ");
                answer = ui.GetInputToUpper()!;

                if (string.IsNullOrWhiteSpace(answer))
                {
                    ui.Print($"You must enter a valid {prompt}, wrong lenght.");
                }
                if (!Regex.Match(answer, "^[A-Z]{3}[0-9]{2}[A-Z-0-9]{1}").Success)
                {
                    ui.Print($"You must enter a valid pattern AAA111 or AAA11A {prompt}");
                }

                else
                {
                    success = true;
                }

            } while (!success);

            return answer;
        }

        public static uint AskForUInt(string prompt, IUI ui)
            {
                do
                {
                    string input = AskForString(prompt, ui);

                    //Anropa AskForString så vi vet att vi faktiskt får en string tillbaks
                    //Fortsätter tills vi har fått en string som vi kan Parsa till en uint
                    if (uint.TryParse(input, out uint answer))
                    {
                        return answer;
                    }

                } while (true);

            }

        public static int AskForInt(string prompt, IUI ui)
        {
            do
            {
                string input = AskForString(prompt, ui);

                //Anropa AskForString så vi vet att vi faktiskt får en string tillbaks
                //Fortsätter tills vi har fått en string som vi kan Parsa till en int
                if (int.TryParse(input, out int answer))
                {
                    return answer;
                }

            } while (true);

        }
    }
 
}
