
using Microsoft.VisualBasic;
using System.Runtime.ConstrainedExecution;
using System;
using System.Security.Cryptography;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

namespace Exercise2
{
    internal class Program
    {

        static void Main(string[] args)
        {
                  
            do
            {
                Console.WriteLine("-----------------------------------\n");
                Console.WriteLine("Menyval\n\r");
                Console.WriteLine("[0]Quit:");
                Console.WriteLine("[1]Ungdom eller pensionär:||[11]Grupp?");
                Console.WriteLine("[2]Upprepa tio gånger:");
                Console.WriteLine("[3]Det tredje ordet:");
                Console.WriteLine("-----------------------------------\n");

                string input = Console.ReadLine()!;

                switch (input)
                {
                    case "0":
                        Environment.Exit(0);
                        break;
                    case "1":
                        Menyval1();
                        Menyval11();
                        break;
                    case "11":
                        Menyval11();
                        break;
                    case "2":
                        Menyval2();
                        break;
                    case "3":
                        Menyval3();
                        break;

                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

            } while (true);


            static void Menyval1()
            {
                //********************************
                //Menyval 1:  Ungdom eller pensionär
                //********************************
                Console.WriteLine("-----------------------------------\n");
                Console.WriteLine("Menyval 1:  Ungdom eller pensionär\r\n");
                Console.WriteLine("-----------------------------------\n");

                Console.WriteLine("Hur gammal är du?");
                var inputAge = Console.ReadLine()!;

                //Error Handling || try & catch
                try
                {
                    uint input = UInt16.Parse(inputAge);
                    //Console.WriteLine(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse '{inputAge}'");
                }

                uint age = UInt16.Parse(inputAge);

                if (age < 20)
                {
                    Console.WriteLine("Ungdomspris: 80kr");

                }
                else if (age > 64)
                {
                    Console.WriteLine("Pensionärspris: 90kr");

                }
                else
                {
                    Console.WriteLine("Standardpris: 120kr");
                }

            }
            static void Menyval11()
            {
                //********************************
                //Menyval 1:1  Grupp
                //********************************
                Console.WriteLine("-----------------------------------\n");
                Console.WriteLine("Menyval 1:1  Totalkostnad för hela sällskapet?\r\n");
                Console.WriteLine("-----------------------------------\n");

                Console.WriteLine("Antal personer i gruppen?");
                int inputGroupSize = Int16.Parse(Console.ReadLine()!);

                int[] allPeopleAgeInTheGroup = new int[inputGroupSize];

                for (int i = 0; i < allPeopleAgeInTheGroup.Length; i++)
                {
                    Console.Write($"Ålder för person[{i + 1}]:");
                    int ageValue = int.Parse(Console.ReadLine()!);
                    allPeopleAgeInTheGroup[i] = ageValue;
                }

                var totalKostnad = 0;
                for (int i = 0; i < allPeopleAgeInTheGroup.Length; i++)
                {
                    if (allPeopleAgeInTheGroup[i] is >= 5 and < 20 )
                    { totalKostnad = totalKostnad + 80; }
                    else if (allPeopleAgeInTheGroup[i] is >= 20 and < 64)
                    { totalKostnad = totalKostnad + 120; }
                    else if (allPeopleAgeInTheGroup[i] is >= 64 and < 100)
                    { totalKostnad = totalKostnad + 90; }
                    else
                    { totalKostnad = + totalKostnad; }
                }

                Console.WriteLine("-----------------------------------\n");
                Console.WriteLine($"Totalkostnad:{totalKostnad} (för {inputGroupSize} personer.)\r\n");
                Console.WriteLine("-----------------------------------\n");
            }
            static void Menyval2()
            {
                //********************************
                //Menyval 2: Upprepa tio gånger
                //********************************
                Console.WriteLine("-----------------------------------\n");
                Console.WriteLine("Menyval 2: Upprepa tio gånger\r\n");
                Console.WriteLine("-----------------------------------\n");

                Console.Write("Ordet som skall upprepa tio gånger:");
                string input2 = Console.ReadLine()!;
                //Using List || Start
                List<string> input2List = new List<string>();
                for (int i = 0; i < 10; i++)
                {
                    input2List.Add(input2.ToString());
                }

                Console.WriteLine("-----------------------------------\n");
                Console.WriteLine(String.Join(", ", input2List));//Output:"input2, input2, input2, input2, input2"
                Console.WriteLine("-----------------------------------\n");
                /* String.Join [Character]
                for (int i = 0; i < 10; i++)
                {
                    Console.Write(String.Join("," ,input2));
                }
                */
            }
            static void Menyval3()
            {
                //********************************
                //Menyval 3: Det tredje ordet
                //********************************
                Console.WriteLine("-----------------------------------\n");
                Console.WriteLine("Menyval 3: Det tredje ordet\r\n");
                Console.WriteLine("-----------------------------------\n");

                Console.Write("Anger en mening med minst 3 ord:");
                string phrase = Console.ReadLine()!;

                phrase = Regex.Replace(phrase, @"\s+", " ").Trim(); // Escape all whitespace and Trim()!
                string[] words = phrase.Split(' ');

                //Console.WriteLine($"{words.Length} words in text:");
                Console.WriteLine($"{words[2]} är det tredje ordet!");

                

                /*
                foreach (var word in words)//9 words in the phrase
                {
                    System.Console.WriteLine($"<{word}>");//output words
                }
                */
            }

        }


    }
}