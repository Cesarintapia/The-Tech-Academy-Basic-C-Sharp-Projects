using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismJob
{
    class Program
    {
        static void Main(string[] args)
        {
            
            IQuitable employee = new Employee();               //Create an "employee" objet, instancing the interface "IQuitable". 
            employee.Quit();                                   //Call "Quit" Method using the object employee
            Console.ReadLine();
        }

    }
}
