using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();             //Instance the Class "Employee" in "employee".
            employee.firstName = "Sample";                  //Asing to the property firstName the value Sample.
            employee.lastName = "Student";                  //Asing to the property lastName the value Student.
            employee.SayName();                             //Call the Method SayName using the employee instance

            Console.ReadLine();
        }
    }
}
