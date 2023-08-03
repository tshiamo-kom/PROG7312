using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region FirstArray
            //2D Array
            int[,] ar = new int[2, 3] { { 2, 4, 6 }, { 8, 10, 12 } };
            //display elements
            DisplayElements(ar);
            //print 4
            //print 8
            
            Console.WriteLine(ar[0,1]);
            Console.WriteLine(ar[0,1]);
            Console.WriteLine("=====FirstArray======");
            #endregion

            #region SecondArray
            int[,] ar1 = new int[2, 4];

            //manual addition of numbers
            ar1[0,0] = 6;
            ar1[0, 1] = 7;
            ar1[0, 2] = 8;
            ar1[0, 3] = 10;
            ar1[1, 0] = 18;
            ar1[1, 1] = 47;
            ar1[1,2] = 15;
            ar1[1,3] = 12;

            DisplayElements(ar1);
            Console.WriteLine("=====SecondArray======");
            #endregion

            #region thirdArray
            //add the values in without usng the above 2ndArray
            int[,] ar2 = new int[4, 4];
            int number = 0;

            //add 1 - 16 without input
            //first row(a) saves the position
            //the column(o) will increase the number
            for (int a = 0; a < ar2.GetLength(0); a++)
            {
                for (int o = 0; o < ar2.GetLength(0); o++)
                {
                    number++;
                    ar2[a,o] = number;
                }
            }

            DisplayElements(ar2);
            #endregion

            Console.Read();
        }

        /// <summary>
        /// method displaying elements of multidimensional array
        /// </summary>
        /// <param name="ar"></param>
        static void DisplayElements(int[,] ar)
        {
            //Display all the elements in array
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    Console.WriteLine(ar[i, j]);
                }

            }
        }
    }
}
