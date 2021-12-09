using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_an_operator
{
    public class Employee : Person, IQuitable                     //Set heritages from Person class and IQuitable Interface, to the class Employee 
    {
        public int Id { get; set; }
        public override void SayName()                           //Override the method SayName.
        {
            base.SayName();                                      //Using the method SayName.
            Console.WriteLine("m employee. Name: ");             //Creating new print overrring.
        }
        public void Quit()                                       //Calling the "Quit" method and set "public"
        {
            Console.WriteLine("quit employee Name: " + FirstName + LastName);   //Perform the function of the method
        }
        public static bool operator == (Employee employeeParrot1, Employee employeeParrot2)  //Definig bool operator == to compare the employeeParrot1 and employeeParrot1 
        {
            return (employeeParrot1.Id == employeeParrot2.Id);                               //Return bool result as true
        }
        public static bool operator != (Employee employeeParrot1, Employee employeeParrot2)  //Definig bool operator == to compare the employeeParrot1 and employeeParrot1
        {
            return (employeeParrot1.Id != employeeParrot2.Id);                               //Return bool result as true
        }

    }
}
