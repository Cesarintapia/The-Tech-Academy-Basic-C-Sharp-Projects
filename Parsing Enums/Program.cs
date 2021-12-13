using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Week week = new Week();                                                       //instance the class Week
            Console.WriteLine("Please enter an actual day of the week in spanish.");      //Ask for a spanish day
            string dayUser = Console.ReadLine();                                          //Save the input in "dayUser"

            Week.Days days;                                                               //Assign the value to a variable of that enum data type
            try
            {
                if (Enum.TryParse(dayUser, true, out days))                               //Compare the "dayUser" with the "Enum Days" and return boolean result
                {
                    Console.WriteLine($"You entered {days}");
                }
                else
                {
                    throw new Exception("...Please enter an actual day of the week.");   //Exception when "dayUser" is false
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);                                         //Message default for the wrong input.
            }
            Console.ReadLine();
        }
    }
}
