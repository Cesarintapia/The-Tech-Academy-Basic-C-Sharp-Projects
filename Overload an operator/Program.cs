using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_an_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee() { Id = 12345, FirstName = "Guero"};      //Instance Employee and set values Id and Firtname.
            Employee employee2 = new Employee() { Id = 12345, FirstName = "Prieto" };    //Instance Employee and set values Id and Firtname.  
            if (employee1 == employee2)                                                  //Compare employee1 and employee2.
            {
                Console.WriteLine("Same Id");                                            //Print result.
            }
            else
            {
                Console.WriteLine("Diferent Id");                                        //Print result.
            }
            Console.ReadLine();
        }
    }
}
