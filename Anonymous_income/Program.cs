using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_income
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\tSnonymous Income Comparation Program"); //Print title
            
            Console.WriteLine("Person 1: ");           //title of person 1 
            Console.WriteLine("Hours rate: ");         //ask the hour rate
            string hoursRate = Console.ReadLine();         //save the hours rate in a string "hoursRate"
            int hoursRatePerson1 = Convert.ToInt32(hoursRate);    //Change the String "the hours rate" to integer "hoursRatePerso1"
            Console.WriteLine("Hours worked per week: ");        //ask for hours per week
            string hoursWeek = Console.ReadLine();              //save the hours per week in a string "hoursWeek"
            int hoursWeekPerson1 = Convert.ToInt32(hoursWeek);    //Change the String "Hours per week" to integer "hoursWeekPerson1"



            Console.WriteLine("Person 2: ");  //title of person 2 
            Console.WriteLine("Hours rate: ");   //ask the hour rate
            string hoursRate2 = Console.ReadLine(); //save the hours rate in a string "hoursRate2"
            int hoursRatePerson2 = Convert.ToInt32(hoursRate2); //Change the String "the hours rate" to integer "hoursRatePerso2"
            Console.WriteLine("Hours worked per week: ");  //ask for hours per week
            string hoursWeek2 = Console.ReadLine();   //save the hours per week in a string "hoursWeek2"
            int hoursWeekPerson2 = Convert.ToInt32(hoursWeek2);  //Change the String "Hours per week" to integer "hoursWeekPerson2"

            //Section to make the math operations for calculate the anual salary and be allow to compare
            double salaryPerson1 = hoursRatePerson1 * hoursWeekPerson1 * 52;
            double salaryPerson2 = hoursRatePerson2 * hoursWeekPerson2 * 52;
            bool comparationSalary = salaryPerson1 > salaryPerson2;

            //Section to print the results of the math operations.
            Console.WriteLine("Details for person 1");
            Console.WriteLine("Hourly Rate: " + hoursRatePerson1);
            Console.WriteLine("Hours worked per week: " + hoursWeekPerson1);
            Console.WriteLine("The anual salary for person1 is: " + salaryPerson1);
            Console.WriteLine("Details for person 2");
            Console.WriteLine("Hourly Rate: " + hoursRatePerson2);
            Console.WriteLine("Hours worked per week: " + hoursWeekPerson2);
            Console.WriteLine("The anual salary for person2 is: " + salaryPerson2);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(comparationSalary);
            Console.ReadLine();
        }
    }
}
