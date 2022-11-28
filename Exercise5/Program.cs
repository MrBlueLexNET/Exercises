using System.ComponentModel;
using System.Security.Cryptography;

namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            // Util-klass for input validation
            /* https://github.com/Lexicon-Net/EmployeeList/blob/master/EmployeeList.Helpers/Util.cs*/
            //

            //Statisk klass kan ej instansieras (med andra ord EJ : Util util = new Util())
            //Statiska klasser kan endast ha statiska medlemmar
            //Anropas med klassNamn.MetodNamn tex Util.AskForString("Hej!", new ConsoleUI())

            //Util util = new Util();
            //Util.AskForString("Hej!", new UI());
            

            


            



            ////Filter by [Properties] (no execution) for an int 
            //var q = garage.Where(p => p.RegNumber  = "aaa111";
            ////Sort by name (no execution)
            //q = q.OrderBy(p => p.Name);

            ////Execution
            //foreach (var item in q)
            //{ }

            /***************************/
            /*GenericGarage*/
            /***************************/
            int n = 10;
            Vehicle[] arr = new Vehicle[n]; 

            for (int i = 0; i < n; i++)
            {

                arr[i] = new Vehicle();
            }

            //GenericGarage<Vehicle> genericGarageCity = new GenericGarage<Vehicle>("Generic City Garage", 5);
            //genericGarageCity.RegisterVehicles(new[] { new Car("AAA111", "V40", "Volvo", "Red", 2, 4) });
            //genericGarageCity.RegisterVehicles(new[] { new Car("CCC111", "V40" , "Volvo", "Black", 2, 4 ) });
            //genericGarageCity.RegisterVehicles(new[] { new Car("AAA111", "V40", "Volvo", "Red", 2, 4) });
            //genericGarageCity.RegisterVehicles(new[] { new Car("CCC111", "V40", "Volvo", "Black", 2, 4) });
            //genericGarageCity.RegisterVehicles(new[] { new Car("AAA111", "V40", "Volvo", "Red", 2, 4) });
            //genericGarageCity.RegisterVehicles(new[] { new Car("CCC111", "V40", "Volvo", "Black", 2, 4) });
            //genericGarageCity.RegisterVehicles(new[] { new Car("AAA111", "V40", "Volvo", "Red", 2, 4) });
            //genericGarageCity.RegisterVehicles(new[] { new Car("CCC111", "V40", "Volvo", "Black", 2, 4) });
            //genericGarageCity.RegisterVehicles(new[] { new Car("AAA111", "V40", "Volvo", "Red", 2, 4) });
            //genericGarageCity.RegisterVehicles(new[] { new Car("CCC111", "V40", "Volvo", "Black", 2, 4) });
            //genericGarageCity.RegisterVehicles(new[] { new Car("AAA111", "V40", "Volvo", "Red", 2, 4) });
            //genericGarageCity.RegisterVehicles(new[] { new Car("CCC111", "V40", "Volvo", "Black", 2, 4) });

            //Console.WriteLine("==========================");
            //genericGarageCity.ShowVehicles(ref Vehicles);
            //Console.WriteLine("==========================");

            //Console.WriteLine($"Number of vehicle in garage: {genericGarageCity.vehicles[1]}");//vehicles System.Array[] null Error throwed

            
            var man = new Manager();
            man.SayHiManager();
            man.ShowMenu();



            Console.ReadKey();

        }
    }
}