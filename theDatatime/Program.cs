using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace theDatatime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime eldatatime = DateTime.Now;                                                  //Make the Object date time type
            Console.WriteLine(eldatatime.ToString("dddd, dd MMMM yyyy HH:mm:ss"));               //Print the current Date Time
            Console.WriteLine("Please pick a number");                                           //Input user of a number
            int elnumber = Convert.ToInt32(Console.ReadLine());                                  //Save the user input
            
            DateTime eldatatime1 = DateTime.Now;
            Console.WriteLine("You choose: " + elnumber + " at " + eldatatime1.ToString());      //Print the result the number and the current date time
            
            DateTime laSumHours = eldatatime.AddHours(elnumber);                                 //Set new Date time variable and Sum elnumber
            Console.WriteLine();
            Console.WriteLine("You Add: " + elnumber + " Hours now the time is " + laSumHours);  //Print the results

            Console.ReadLine();

        }
    }
}
