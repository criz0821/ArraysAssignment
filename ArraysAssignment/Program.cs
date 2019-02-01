/*
 *  Author: Christopher Mejia
 *  Date: 1/31/19
 * 
 */
using System;

namespace ArraysAssignment
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int[] myValues = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

                for (int i = 0; i < myValues.Length; i++)
                {
                    Console.WriteLine("Element Value = " + myValues[i]);
                    Console.WriteLine("The Element Subscript for this Value is " + i);
                    Console.ReadKey(true);

                }// end of for loop

                Console.WriteLine("All values in the array have been displayed. Press any key to exit");
                Console.ReadKey(true);
            }// end of try

            catch
            {
                Console.WriteLine("An Error ocurred! Press any key to exit.");
                Console.ReadKey(true);
            }// end of catch
        }// end of main
    }//end of class
}// end of namespace
