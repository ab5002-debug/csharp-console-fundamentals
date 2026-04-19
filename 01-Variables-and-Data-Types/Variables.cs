using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lesson1._01_Variables_and_Data_Types
{
    internal class Variables
    {
        public static void Lesson1()
        {
            #region Printing Commands

            //Console.WriteLine("Hello, World!");
            //Console.Write("Hi!");
            //Diffrence between WriteLine and Write is that WriteLine adds a new line after the text, while Write does not.

            //Console.WriteLine("***** Food Categories *****");
            //Console.WriteLine();
            //Console.WriteLine("1-Soups");
            //Console.WriteLine("2-Main Foods");
            //Console.WriteLine("3-Cold Starts");
            //Console.WriteLine("4-Salads");
            //Console.WriteLine("5-Desserts");
            //Console.WriteLine("6-Drinks");
            //Console.WriteLine();

            //Console.WriteLine("***** Food Categories *****");

            #endregion

            #region String Variables

            //variable_type variable_name;

            //string name;
            //name = "Arda";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Arda";
            //customerSurname = "Baki";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "example@gmail.com";
            //district  = "Karşıyaka";
            //city = "İzmir";

            //Console.WriteLine("**** Reservation Information ****");
            //Console.WriteLine();
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Customer : " + customerName + " " + customerSurname);
            //Console.WriteLine("Phone : " + customerPhone);
            //Console.WriteLine("Email : " + customerEmail);
            //Console.WriteLine("Address : " + district + " / " + city);
            //Console.WriteLine("-----------------------------------");



            //customerName = "Ahmet";
            //customerSurname = "Yılmaz";
            //customerPhone = "+90 500 400 30 210";
            //customerEmail = "example1@gmail.com";
            //district = "Merkez";
            //city = "Yalova";


            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Customer : " + customerName + " " + customerSurname);
            //Console.WriteLine("Phone : " + customerPhone);
            //Console.WriteLine("Email : " + customerEmail);
            //Console.WriteLine("Address : " + district + " / " + city);
            //Console.WriteLine("-----------------------------------");

            //customerName = "Mehmet";
            //Console.WriteLine(customerName);
            //Variables can be updated after they are declared and assigned a value.





            #endregion

            #region Int Variables

            //int
            //int number = 24;
            //Console.WriteLine(number);

            //int hamburgerPrice = 300;
            //int cokePrice = 35;
            //int waterPrice = 10;
            //int friesPrice = 50;
            //int pizzaPrice = 250;
            //int lemonadePrice = 30;

            //Console.WriteLine("***** Restaurant Menu *****");
            //Console.WriteLine();
            //Console.WriteLine("-----Hamburger Price: " + hamburgerPrice + "TL");
            //Console.WriteLine("-----Pizza Price: " + pizzaPrice + "TL");
            //Console.WriteLine("-----Coke Price: " + cokePrice + "TL");
            //Console.WriteLine("-----Lemonade Price: " + lemonadePrice + "TL");
            //Console.WriteLine("-----Fries Price: " + friesPrice + "TL");
            //Console.WriteLine("-----Water Price: " + waterPrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine("***** Restaurant Menu *****");

            //Console.WriteLine();
            //int hamburgerCount,cokeCount, waterCount, friesCount, pizzaCount, lemonadeCount,totalHamburgerPrice;
            //int totalCokePrice , totalWaterPrice , totalFriesPrice , totalPizzaPrice , totalLemonadePrice;

            //hamburgerCount = 3;
            //cokeCount = 3;
            //waterCount = 3;
            //friesCount = 1;
            //pizzaCount = 0;
            //lemonadeCount = 0;

            //totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            //totalCokePrice = cokeCount * cokePrice;
            //totalFriesPrice = friesCount * friesPrice;
            //totalPizzaPrice = pizzaCount * pizzaPrice;
            //totalLemonadePrice = lemonadeCount * lemonadePrice;
            //totalWaterPrice = waterCount * waterPrice;

            //Console.WriteLine("---------------------------------------");
            //Console.WriteLine("Hamburger Amount: " + totalHamburgerPrice + " TL ");
            //Console.WriteLine("Coke Amount: " + totalCokePrice + " TL ");
            //Console.WriteLine("Water Amount: " + totalWaterPrice + " TL ");
            //Console.WriteLine("Fries Amount: " + totalFriesPrice + " TL ");
            //Console.WriteLine("Pizza Amount: " + totalPizzaPrice + " TL ");
            //Console.WriteLine("Lemonade Amount: " + totalLemonadePrice + " TL ");
            //Console.WriteLine();

            //int TotalPrice = totalHamburgerPrice + totalCokePrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice + totalWaterPrice;

            //Console.WriteLine("Total Amount: " + TotalPrice + " TL ");

            #endregion

            #region Double Variables

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("---- Apple Price: " + applePrice + " TL");
            //Console.WriteLine("---- Orange Price: " + orangePrice + " TL");
            //Console.WriteLine("---- Strawberry Price: " + strawberryPrice + " TL");
            //Console.WriteLine("---- Potato Price: " + potatoPrice + " TL");
            //Console.WriteLine("---- Tomato Price: " + tomatoPrice + " TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram,orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Product Received : Apple - " + "Unit Price: " + applePrice + " TL - Gram: " + appleGram + " gr - Total Price: " + appleTotalPrice + " TL");
            //Console.WriteLine("Product Received : Orange - " + "Unit Price: " + orangePrice + " TL - Gram: " + orangeGram + " gr - Total Price: " + orangeTotalPrice + " TL");
            //Console.WriteLine("Product Received : Strawberry - " + "Unit Price: " + strawberryPrice + " TL - Gram: " + strawberryGram + " gr - Total Price: " + strawberryTotalPrice + " TL");
            //Console.WriteLine("Product Received : Potato - " + "Unit Price: " + potatoPrice + " TL - Gram: " + potatoGram + " gr - Total Price: " + potatoTotalPrice + " TL");
            //Console.WriteLine("Product Received : Tomato - " + "Unit Price: " + tomatoPrice + " TL - Gram: " + tomatoGram + " gr - Total Price: " + tomatoTotalPrice + " TL");

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine("Total Shopping Price: " + shoppingTotalPrice + " TL");

            #endregion

            #region Char Variables

            //ABCDEFGH
            //DEF...
            //MEETİNG AT 8 PM
            // ' ' 

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion

            #region Keyboard Data Inputs - String Variables

            //Console.WriteLine("**** CSharp Airlines Passenger Information ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Passenger Name: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Passenger Surname: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("District: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("City: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Age: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Identity Number: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("------------------------------");
            //Console.WriteLine("Passenger : " + passengerName + " - " + passengerSurname + " - "  + passengerCity + " - " + passengerAge + " - " + "Passenger Identity Number : "  + passengerIdentityNumber);


            #endregion

            #region Integer Inputs And Conversions From The Keyboard

            //ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Please enter the number of shoes you purchased : ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the number of computer you purchased: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the number of chair you purchased: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Please enter the number of tv you purchased: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine($"Total Price: {totalPrice} TL");



            #endregion

            #region Keyboard Input of Decimal Numbers

            //double exam1, exam2, exam3, result;

            //Console.Write("Please enter the first exam grade : ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Please enter the second exam grade : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Please enter the third exam grade : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Average Grade: " + result);



            #endregion

            #region Char Inputs From The Keyboard

            char gender;
            Console.Write("Please enter your gender (M/F): ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Your gender is: " + gender);

            #endregion


            Console.Read();

            



        }
    }
}
