using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1._01_Variables_and_Data_Types
{
    internal class Variables
    {
        public static void Lesson1()
        {
            #region PrintingCommands

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

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restaurant Menu *****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger Price: " + hamburgerPrice + "TL");
            Console.WriteLine("-----Pizza Price: " + pizzaPrice + "TL");
            Console.WriteLine("-----Coke Price: " + cokePrice + "TL");
            Console.WriteLine("-----Lemonade Price: " + lemonadePrice + "TL");
            Console.WriteLine("-----Fries Price: " + friesPrice + "TL");
            Console.WriteLine("-----Water Price: " + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("***** Restaurant Menu *****");

            Console.WriteLine();
            int hamburgerCount,cokeCount, waterCount, friesCount, pizzaCount, lemonadeCount,totalHamburgerPrice;
            int totalCokePrice , totalWaterPrice , totalFriesPrice , totalPizzaPrice , totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalWaterPrice = waterCount * waterPrice;

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Hamburger Amount: " + totalHamburgerPrice + " TL ");
            Console.WriteLine("Coke Amount: " + totalCokePrice + " TL ");
            Console.WriteLine("Water Amount: " + totalWaterPrice + " TL ");
            Console.WriteLine("Fries Amount: " + totalFriesPrice + " TL ");
            Console.WriteLine("Pizza Amount: " + totalPizzaPrice + " TL ");
            Console.WriteLine("Lemonade Amount: " + totalLemonadePrice + " TL ");
            Console.WriteLine();

            int TotalPrice = totalHamburgerPrice + totalCokePrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice + totalWaterPrice;

            Console.WriteLine("Total Amount: " + TotalPrice + " TL ");

            #endregion

            Console.Read();





        }
    }
}
