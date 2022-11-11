

using System;
using System.Diagnostics.Metrics;

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
           
            UserErrors.Add(numericInputError.UEMessage("Error1: NUM"));
            UserErrors.Add(TextInputError.UEMessage("Error1: TEXT"));
            
            //8.Skriv ut samtliga UserErrors UEMessage() genom en foreach loop. 
            foreach (var error in UserErrors)
            { Console.WriteLine($"Error: {error}"); }
            Console.ReadLine();

        }       
    }
} 