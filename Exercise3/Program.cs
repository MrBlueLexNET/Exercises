

using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Xml.Linq;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try 
            //{ 

            
            //Person person01 = new Person() { FName = "Jean-Yves"};//NOT OK
            ////Person person02 = new Person() { LName = "Michel" };//NOT OK
            ////person01.LName = "D";//To catch block
            //Console.WriteLine(person01.FName);
            ////Console.WriteLine(person02.LName);

            ////person01.Validate();
            //Console.WriteLine(person01.Validate());

            //PersonHandler personHandler01 = new PersonHandler();
            //personHandler01.SetAge(personHandler01, 4);
            //Console.WriteLine($"Age: {personHandler01.Age}");
            //Console.WriteLine(personHandler01.Validate());
            //var BMI = personHandler01.BMI(75, 184);
            //Console.WriteLine($"BMI: {BMI}");

            //    //OOP || Polymorphism 7:49
            //    //as and is BaseClass = Person and derivedObj 
            //    //TOREAD: How to safely cast by using pattern matching and the is and as operators
            //    PersonHandler derivedObj = new PersonHandler();
            //    var i = (derivedObj as Person).Age;//BaseProp if Age property is not define i => Null
                
            //    if (derivedObj is Person)
            //    { 
            //        Console.WriteLine($"Age: {derivedObj.Age} i: {i}"); 
            //    }
                  
            //Console.ReadKey(); //Stop

            //}

            // catch (Exception e)
            //{
            //Console.WriteLine("Error: " + e.Message);
            ////Console.ReadLine();
            //}

            //7.I Program.cs Main-metod: Skapa en lista med UserErrors och populera den med
            //instanser av NumericInputError och TextInputError.
            List<string> UserErrors = new List<string>();

            NumericInputError numericInputError = new NumericInputError();
            TextInputError TextInputError = new TextInputError();
            
            //numericInputError.UEMessage("Error1");
            //numericInputError1.UEMessage("Error2");
           
            UserErrors.Add(numericInputError.UEMessage(""));
            UserErrors.Add(TextInputError.UEMessage(""));

            FileUpploadError fileUpploadError = new FileUpploadError();//[9.1] + Argument
            UserErrors.Add(fileUpploadError.UEMessage("Custom Error Text..."));

            FileSizeError fileSizeError = new FileSizeError();//[9.3] - Argument
            UserErrors.Add(fileSizeError.UEMessage());

            //8.Skriv ut samtliga UserErrors UEMessage() genom en foreach loop. 
            foreach (var message in UserErrors)
            { Console.WriteLine($"Error: {message}"); }

            //TOVIEW: Understanding Interface https://app.pluralsight.com/course-player?clipId=8e8b7469-2a1a-4b63-8acf-662ba7db3f5b

            //[TEST] 12.Implementera Talk() som skriver ut vad Wolfman säger.
            Wolfman wolfman1 = new Wolfman();
            Console.WriteLine($"{wolfman1.Talk()}");
            

            //13.F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt attribut, i vilken klass bör vi lägga det?
            //13.S: I klass Bird
            //14.F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
            //14.S: I klass Animal

            Horse horse1 = new Horse();
            horse1.Name = "Big Dady";
            horse1.Description = "(CHI) ch. H, 2013 {23-a} DP = 5-0-4-1-0 (10) DI = 2.33   CD = 0.90 - 23 Starts, 8 Wins, 4 Places, 1 Shows Career Earnings: $334,530\r\n"; 

            Console.WriteLine($"{horse1.Stats()}");

            Swan sawnBlack = new Swan() { Name = "Black", Description = "I'm in a bad shape today and", Maried = true };
            Console.WriteLine($"{sawnBlack.Stats()}");

            Swan sawnWhite = new Swan() { Name = "White", Description = "I'm in a good shape today and", Maried = false };
            Console.WriteLine($"{sawnWhite.Stats()}");
            //3. Skapa en lista Animals i Program.cs som tar emot djur.
            List<Animal> Animals = new List<Animal>();

            Dog Boxer = new Dog() { Name = "Boxer", Description = "Boxer är en hundras från Tyskland. Den är en brukshund och sällskapshund av molossertyp. I en undersökning 2012/2013 utnämndes boxern till en av världens tio populäraste hundraser." };
            Dog BassetHound = new Dog() { Name = "Basset hound" , Description = "Basset hound är en hundras från Storbritannien. Ursprungligen är den en långsamdrivande jakthund av lågbent braquetyp men den är vanligast som sällskapshund." };
            Horse Mustang = new Horse() { Name = "Mustang" , Description = "Mustang är en hästras som utvecklats naturligt i det vilda i USA. Mustanger är förvildade hästar, i den meningen att de har tillkommit från tama hästar, men sedan förvildats." };
            Wolf wolf = new Wolfman() { Name = "Bob the wolf", Description = "I'm just a regular wolfman and I can talk()" };
            Animals.Add(Boxer);
            Animals.Add(BassetHound);
            Animals.Add(Mustang);
            Animals.Add(wolf);

            //7. Gör en check i for-loopen ifall ett djur även är av typen IPerson, om den är det type 
            //casta till IPerson och anropa dess Talk() metod

            //Typtestning med operatorn typeof
            // Ref: https://learn.microsoft.com/sv-se/dotnet/csharp/language-reference/operators/type-testing-and-cast#cast-expression

            
                object b = new Bird();
                Console.WriteLine(b is Animal);  // output: True
                Console.WriteLine(b.GetType() == typeof(Animal));  // output: False

                Console.WriteLine(b is Bird);  // output: True
                Console.WriteLine(b.GetType() == typeof(Bird));  // output: True
           

            foreach (var animal in Animals)
            { 
            Console.WriteLine($"{animal.Name} Beskrivning: {animal.Description}");
                var o = animal as IPerson;
                if (o != null)
                { Console.WriteLine("Found the correct interface to execute the method Wolfman can SPEAK");
                    Console.WriteLine(o.Talk());
                }              
                Console.WriteLine(animal.DoSound());
            }

//8.Skapa en lista för hundar.
            List<Dog> Doglist = new List<Dog>();
            Doglist.Add(Boxer);
            Doglist.Add(BassetHound);
            //Doglist.Add(Mustang); 

//9.F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?


//10.F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans ?
//11.Skriv ut samtliga Animals Stats() genom en foreach loop.
//12.Testa och se så det fungerar.
//13.F: Förklara vad det är som händer.
//14.Skriv ut Stats() metoden enbart för alla hundar genom en foreach på
//Animals.
//15.Skapa en ny metod med valfritt namn i klassen Dog som endast returnerar en valfri
//sträng.
//16.Kommer du åt den metoden från Animals listan ?
//17.F : Varför inte ?
//18.Hitta ett sätt att skriva ut din nya metod för dog genom en foreach på Animals.

            Console.ReadLine();

        }       
    }
} 