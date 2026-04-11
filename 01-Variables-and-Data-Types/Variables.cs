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

            #region Variables

            //variable_type variable_name;

            //string name;
            //name = "Arda";
            //Console.Write(name);

            string customerName;
            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            customerName = "Arda";
            customerSurname = "Baki";
            customerPhone = "+90 500 400 30 20";
            customerEmail = "example@gmail.com";
            district  = "Karşıyaka";
            city = "İzmir";

            Console.WriteLine("**** Reservation Information ****");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Customer : " + customerName + " " + customerSurname);
            Console.WriteLine("Phone : " + customerPhone);
            Console.WriteLine("Email : " + customerEmail);
            Console.WriteLine("Address : " + district + " / " + city);
            Console.WriteLine("-----------------------------------");
            


            customerName = "Ahmet";
            customerSurname = "Yılmaz";
            customerPhone = "+90 500 400 30 210";
            customerEmail = "example1@gmail.com";
            district = "Merkez";
            city = "Yalova";

            
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Customer : " + customerName + " " + customerSurname);
            Console.WriteLine("Phone : " + customerPhone);
            Console.WriteLine("Email : " + customerEmail);
            Console.WriteLine("Address : " + district + " / " + city);
            Console.WriteLine("-----------------------------------");

            //customerName = "Mehmet";
            //Console.WriteLine(customerName);
            //Variables can be updated after they are declared and assigned a value.





            #endregion
            Console.Read();
        }
    }
}
