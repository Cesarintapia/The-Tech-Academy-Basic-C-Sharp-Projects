using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceJob
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();           //Instance the class Employee  
            employee.FirstName = "Sample";                //Set propierties to "employee" object this and the follow line
            employee.LastName = "Student";                

            employee.SayName();                           //Call the superclass method "SayName"

            Console.ReadLine();
        }
    }
}
