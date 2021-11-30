using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("\t\t\t\t\t The Tech Academy");             //Print title
           Console.WriteLine("\t\t\t\t        Student Daily Report");    //Print subtitle

           Console.WriteLine("What is your full name?");                //First question: your name
            string yourName = Console.ReadLine();                     //save the name in the type string variable: yourName

            Console.WriteLine("What course you are on?");            //Second question: the course
            string yourCourse = Console.ReadLine();                 //Save the course in the type String variable: yourCourse

           Console.WriteLine("What page number you study now?");      //third question: page number
            string yourPage = Console.ReadLine();                     //Save the page number in the type String variable: yourPage
            int page = Convert.ToInt32(yourPage);                     //Convert the type String variable in integer: page and save it. 

            Console.WriteLine("Do you need help with anything? \nPlease answer \"true\" or \"false\""); //four question: need help
            string needHelp = Console.ReadLine();                     //Save the answer in the type String variable: needHelp.
            bool helpStatus = Convert.ToBoolean(needHelp);            //Convert the type String variable in boolean: helpStatus and save it.
            Console.WriteLine(helpStatus);                            //Print the answer...I Know is no necesary this step..just for confirmation.

           Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics"); //Five questio: positive experiences
            string positiveExperiences = Console.ReadLine();        //Save the answer in the type String Varibale: positiveExperiencies

           Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific"); //six question
            string feedBack = Console.ReadLine();                    //Save the answer in the type String Variable: feedBack

           Console.WriteLine("How many hours did you study today?");    //Seven question
            string hoursStudy = Console.ReadLine();                     // Save the hours in the Type String Variable: hoursStudy
            int hours = Convert.ToInt32(hoursStudy);                    // Convert the Type String Variable: hoursStudy in integer: hous and save it

           Console.WriteLine("\tThank you for your answers. An Instructor will respond to this shortly. Have a great day!"); // Print final message
           
           Console.ReadLine();

        }
    }
}
