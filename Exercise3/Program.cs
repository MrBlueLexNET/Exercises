

using System;
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

            Console.ReadLine();

        }       
    }
} 