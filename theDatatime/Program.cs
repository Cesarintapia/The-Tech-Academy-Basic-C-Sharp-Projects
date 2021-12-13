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
            DateTime eldatatime = DateTime.Now;                                              //Make the Object data time type

            Console.WriteLine(eldatatime.ToString("dddd, dd MMMM yyyy HH:mm:ss"));           //Print the current Data Time
            Console.WriteLine("Please pick a number");                                       //Input user of a number
            int elnumber = Convert.ToInt32(Console.ReadLine());                              //Save the user input
            Console.WriteLine("You choose: " + elnumber + " at " + eldatatime.ToString());   //Print the result the number and the current data time

            Console.ReadLine();

        }
    }
}
