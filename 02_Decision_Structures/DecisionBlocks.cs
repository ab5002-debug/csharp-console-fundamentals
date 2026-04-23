using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson._02_Decision_Structures
{
    internal class DecisionBlocks
    {
        public static void DecisionBlocksLesson()
        {
            #region If-Else Blocks

            //  Console.Write("Please enter a password: ");
            //  string password;
            //  password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Password is correct!");
            //}
            //else
            //{
            //    Console.WriteLine("Password is incorrect!");
            //}

            //string capital, country;
            //Console.Write("Enter a country: ");
            //capital = Console.ReadLine();
            //Console.Write("Enter the capital of that country: ");
            //country = Console.ReadLine();

            //if(capital == "Ankara" & country == "Turkey")
            //{
            //    Console.WriteLine("Correct!");
            //}
            //else
            //{
            //    Console.WriteLine("Incorrect!");
            //}

            //int number;
            //Console.Write("Enter a number: ");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Correct!");
            //} else
            //{
            //    Console.WriteLine("Incorrect!");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Error!";

            //Console.Write("Enter the first exam score: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the second exam score: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the third exam score: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average =(exam1 + exam2 + exam3) / 3;
            //Console.Write("Average score: " + average + "\n");

            //if (average > 0 & average <= 50)
            //{
            //    result = "Result: Fail";
            //}

            //if(average > 50 & average <= 70)
            //{
            //    result = "Result: Medium";
            //}

            //if(average > 70 & average <= 84)
            //{
            //    result = "Result: High";
            //}

            //if (average > 84)
            //{
            //    result = "Result: Excellent";
            //}

            //Console.WriteLine(result);


            //string city;
            //Console.Write("Enter a city: ");
            //city = Console.ReadLine();

            //if(city == "Adana" | city == "Ankara" | city == "Bursa" | city == "Trabzon")
            //{
            //    Console.WriteLine("This city exists in Turkey.");
            //}
            //else
            //{
            //    Console.WriteLine("This city does not exist in Turkey.");
            //}


            //Console.Write("Enter a username: ");
            //string username = Console.ReadLine();
            //if (username != "admin")
            //{
            //    Console.Write("Access denied!");
            //}
            //else
            //{
            //    Console.Write("Welcome, admin!");
            //}

            #endregion

            #region Mode Operations

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine("The result of the operation is: " + result);

            //Console.Write("Enter a first number: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter a second number: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write("The result of the operation is: " + result + "\n" );

            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.Write("This number is even.");
            //}
            //else
            //{
            //    Console.Write("This number is odd.");
            //}

            #endregion

            #region Decision Structures with Char Variables
            //char team;
            //Console.Write("Please enter the team symbol: ");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'g' | team == 'G')
            //{
            //    Console.Write("Galatasaray");
            //}
            //else if(team == 'f' | team == 'F')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //else if(team == 'b' | team == 'B')
            //{
            //    Console.Write("Beşiktaş");
            //}
            //else
            //{
            //    Console.Write("Unknown team symbol.");
            //}

            #endregion

            #region Sample Project Application

            //Console.WriteLine("****** CSharp Training Camp Restaurant ******");
            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine("1-Main Foods");
            //Console.WriteLine("2-Soups");
            //Console.WriteLine("3-Pizzas");
            //Console.WriteLine("4-Drinks");
            //Console.WriteLine("5-Desserts");
            //Console.WriteLine("-------------------------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Please select the menu you would like to see: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Main Foods----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Kebab");
            //    Console.WriteLine("2-Lahmacun");
            //    Console.WriteLine("3-Pita Bread");
            //    Console.WriteLine("4-Manti");
            //    Console.WriteLine("5-Chicken");
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Main Foods----------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Soups----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Lentil Soup");
            //    Console.WriteLine("2-Ezogelin Soup");
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Soups----------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Pizzas----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mediterrenian Pizza");
            //    Console.WriteLine("2-Margarita Pizza");
            //    Console.WriteLine("3-Chicken Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Pizzas----------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Drinks----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Cola");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Water");
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Drinks----------------");

            //    Console.WriteLine();
            //}

            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Desserts----------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trilece");
            //    Console.WriteLine("2-Kadayif");
            //    Console.WriteLine("3-Kazandibi");
            //    Console.WriteLine();
            //    Console.WriteLine("---------------Desserts----------------");

            //    Console.WriteLine();
            //}

            #endregion

            #region Switch-Case Blocks and Month Number Example

            //Console.Write("Please enter a month number: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("January"); break;
            //    case 2: Console.Write("February"); break;
            //    case 3: Console.Write("March"); break;
            //    case 4: Console.Write("April"); break;
            //    case 5: Console.Write("May"); break;
            //    case 6: Console.Write("June"); break;
            //    case 7: Console.Write("July"); break;
            //    case 8: Console.Write("August"); break;
            //    case 9: Console.Write("September"); break;
            //    case 10: Console.Write("October"); break;
            //    case 11: Console.Write("November"); break;
            //    case 12: Console.Write("December"); break;
            //    default: Console.Write("Invalid month number!"); break;
            //}

            #endregion

            #region Switch-Case Calculator Project

            //int num1, num2, result;
            //char symbol;

            //Console.Write("Enter the first number: ");
            //num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //num2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the operation symbol (+, -, *, /): ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        Console.WriteLine("Result: " + result);
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine("Result: " + result);
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine("Result: " + result);
            //        break;
            //    case '/':
            //        result = num1 / num2;
            //        Console.WriteLine("Result: " + result);
            //        break;

            //    default: Console.WriteLine("Invalid operation symbol!"); break;
            //}



            #endregion


            Console.Read();
        }
    }
}
