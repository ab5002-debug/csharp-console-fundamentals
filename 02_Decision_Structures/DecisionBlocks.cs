using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson._02_Decision_Structures
{
    internal class DecisionBlocks
    {
        public static void DecisionBlocksLesson()
        {
            #region IF Blocks

              Console.Write("Please enter a password: ");
              string password;
              password = Console.ReadLine();
            if (password == "abcd")
            {
                Console.WriteLine("Password is correct!");
            }
            else
            {
                Console.WriteLine("Password is incorrect!");
            }

            string capital, country;
            Console.Write("Enter a country: ");
            capital = Console.ReadLine();
            Console.Write("Enter the capital of that country: ");
            country = Console.ReadLine();

            if(capital == "Ankara" & country == "Turkey")
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }

            int number;
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number == 5)
            {
                Console.WriteLine("Correct!");
            } else
            {
                Console.WriteLine("Incorrect!");
            }

            int exam1, exam2, exam3, average;
            string result = "Error!";

            Console.Write("Enter the first exam score: ");
            exam1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second exam score: ");
            exam2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third exam score: ");
            exam3 = int.Parse(Console.ReadLine());

            average =(exam1 + exam2 + exam3) / 3;
            Console.Write("Average score: " + average + "\n");

            if (average > 0 & average <= 50)
            {
                result = "Result: Fail";
            }
            
            if(average > 50 & average <= 70)
            {
                result = "Result: Medium";
            }
            
            if(average > 70 & average <= 84)
            {
                result = "Result: High";
            }
            
            if (average > 84)
            {
                result = "Result: Excellent";
            }

            Console.WriteLine(result);


            string city;
            Console.Write("Enter a city: ");
            city = Console.ReadLine();

            if(city == "Adana" | city == "Ankara" | city == "Bursa" | city == "Trabzon")
            {
                Console.WriteLine("This city exists in Turkey.");
            }
            else
            {
                Console.WriteLine("This city does not exist in Turkey.");
            }


            Console.Write("Enter a username: ");
            string username = Console.ReadLine();
            if (username != "admin")
            {
                Console.Write("Access denied!");
            }
            else
            {
                Console.Write("Welcome, admin!");
            }

            #endregion

            Console.Read();
        }
    }
}
