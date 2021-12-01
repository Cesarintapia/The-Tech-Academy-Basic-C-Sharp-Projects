using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuransQualification
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("What is your age?");  //Ask for the age
            string age = Console.ReadLine();         //Save the age in Type String Varible "age" 
            int agePerson = Convert.ToInt32(age);    //Convert age in Integer in save in "agePerson" 
            int ageLegal = 18;                       // Set condition type integer
            bool agePermited = agePerson >= ageLegal; // Compare ageLegal with agePerson and the result is agePermited tyoe boolean
            Console.WriteLine(agePermited);            // Printe Permited age

            Console.WriteLine("Have you ever had a DUI? answer:\"true\" or \"false\""); //Ask for DUI
            bool dui = Convert.ToBoolean(Console.ReadLine());         //Conver the answer in boolean

            Console.WriteLine("How many speeding tickets do you have?");  //Ask for the tickets
            int tickets = Convert.ToInt32(Console.ReadLine());           //Save the answer in type integer variable: "tickets"
            bool ticketSpeending = tickets <= 3;                         // perform the boolean operator between tickets and number 3  

            Console.WriteLine("Qualified: ");    //Write the result of the qualification
            Console.WriteLine(dui ^ ticketSpeending && agePermited); //perform the boolean operator for result
            
            Console.ReadLine();
        }
    }
}