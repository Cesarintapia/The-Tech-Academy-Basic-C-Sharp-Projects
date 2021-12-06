using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_and_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[] integersList = { 45, 12, 45, 43, 99, 89, 21, 5, 0 };                         //Starting the List
                Console.WriteLine("Pick a number.");                                               //Ask for a number
                int numberUser = Convert.ToInt32(Console.ReadLine());                              //Save the response in "numberUser"
                Console.WriteLine(" When " + numberUser + " Divide the List... the result is:");   //Print message to start
                for (int i = 0; i < integersList.Length; i++)                                      //Start loop to use all the list
                {
                   int numberResult = integersList[i] / numberUser;                                //Perform the division
                   Console.WriteLine(numberResult);                                                //Print the result
                }
            }
             catch (FormatException error)                                                         //Exception by format, prevent the user to not type strings
            {
                Console.WriteLine("Please write a whole number... string is not valid..." + error.Message);  //Print message to prevent about strings
            }
            catch (DivideByZeroException error)                                                     //Exception by zero division
            {
                Console.WriteLine(" impossible" + error.Message);                                   //Print message to show not divide by zero
            }
                catch (Exception error)                                                             //General exception.
            {
                Console.WriteLine(error.Message);
            }
            finally                                                                                 //Print defaul message
            {
                Console.WriteLine();
                Console.WriteLine(" Esta seccion works");
            }
            Console.ReadLine();
        }
    }
}
