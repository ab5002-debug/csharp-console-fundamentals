using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Lesson._03_Loops
{
    internal class Loops
    {
        public static void LoopsLesson()
        {
            #region For Loops

            //For(x;y;z)
            //x:start
            //y:end
            //z:increase

            //int i;

            //for (i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("CSharp Training Camp");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Please enter the quantity you wish to be printed: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("LONG LIVE THE REPUBLİC!");
            //}




            #endregion

            #region For Loops with Decision Structures

            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }

            //}

            //int totalValue = 0;

            //for (int i = 1; i <= 10 ; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);

            //int totalValue = 0;

            //for(int i = 1; i < 20; i++)
            //{
            //    if(i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("--------");
            //Console.WriteLine(totalValue);


            //int count = 0;

            //for (int i = 1; i <= 50; i++)
            //{
            //    if(i % 7 == 0)
            //    {
            //        count++;
            //    }
            //}

            //Console.WriteLine(count);

            //1-2-4-8-16...

            //int bacterium = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine("After"+ " " + i + " " + "Hour: " + bacterium);
            //}

            #endregion

            #region While Loops

            //While(condition)
            //{
            //transaction
            //}

            //int i = 1;

            //while (i <= 10)
            //{
            //    Console.WriteLine("Hello Loops!");
            //    i++;
            //}


            //int i = 1;

            //while (i <= 10)
            //{
            //    if(i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}


            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);



            #endregion

            #region Sample Exam Question

            //What is the code that calculates the sum of the digits of a 3-digit number entered from the keyboard?

            //Console.Write("Enter a number (3-digits) : ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //hundreds = number / 100;
            //tens = (number % 100) / 10;

            //sum = ones + hundreds + tens;

            //Console.WriteLine(sum);




            #endregion

            #region Loops with Stars

            #region Create 10 stars one below the other

            //for (int i = 1; i <= 10 ; i++)
            //{
            //    Console.WriteLine("*");
            //}


            #endregion

            #region Create 10 stars side by side

            //for (int i = 1; i <= 10 ; i++)
            //{
            //    Console.Write("*");
            //}

            #endregion

            #region Create 10 stars one below the other, with 10 stars in each row

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine("**********");
            //}


            #endregion

            #region Right triangle with stars

            //for (int i = 1; i <= 5 ; i++)
            //{
            //    for (int j = 1; j <= i ; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Reverse right triangle with stars

            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Diamond with stars

            //for(int i = 1; i <= 5;  i++)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for(int k = 4; k >= 1; k--)
            //{
            //    for(int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}



            #endregion

            #region Baklava with stars

            //int n = 5;

            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n-1 ; j > 0 ; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = n-1 ; i >= 1; i--)
            //{
            //    for (int j = n-1 ; j > 0 ; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2*i-1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Pyramid with stars

            //int n = 5;

            //for(int i = 1; i<=n; i++)
            //{
            //    for (int j = n-i; j > 0 ; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2 * i-1 ; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion

            #region Reverse pyramid with stars

            //int n = 5;
            //for (int i = n; i >= 1 ; i--)
            //{
            //    for (int j = n-i; j > 0  ; j--)
            //    {
            //        Console.Write(" ");
            //    }

            //    for (int k = 1; k <= 2*i-1;k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            #endregion


            #endregion
            Console.Read();
        }
    }
}