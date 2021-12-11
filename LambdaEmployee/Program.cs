using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaEmployee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> totalList = new List<Employee> { };                                            //Instance List<Employee> y create the list
            totalList.Add(new Employee(12345, "Joe", "barrera"));                                         //Add Values to totalList
            totalList.Add(new Employee(12346, "Jenifer", "Lopez"));
            totalList.Add(new Employee(12347, "Nicki", "Minaje"));
            totalList.Add(new Employee(12348, "Bart", "Pitt"));
            totalList.Add(new Employee(12349, "Stevee", "Wonder"));
            totalList.Add(new Employee(12350, "Joe", "Smith"));
            totalList.Add(new Employee(12351, "Andy", "Garcia"));
            totalList.Add(new Employee(12352, "Salma", "Hayek"));
            totalList.Add(new Employee(12353, "Elizabeth", "Howtorn"));
            totalList.Add(new Employee(12354, "Joe", "Black"));
         
            List<Employee> employee1 = new List<Employee> { };                                            //Make a empty list employee1
            foreach (Employee employee in totalList)                                                      //Loop to check totalList
            {
                
                if (employee.firstName == "Joe")
                {
                    employee1.Add(employee);                                                              //Add values to employee1
                    Console.WriteLine(employee.Id + " " + employee.firstName + " " + employee.lastName);  //Print result
                }
            }
            Console.WriteLine();

            Console.WriteLine("Using Lambda");
            Console.WriteLine();
            
            List<Employee> nameList = totalList.Where(x => x.firstName == "Joe").ToList();                //Make List with lambda expresion
            foreach (Employee name in nameList)                                                           //Loop to print
            {
                Console.WriteLine(name.firstName + " " + name.lastName + " " + name.Id);
            }
            Console.WriteLine();
            
            List<Employee> idList = totalList.Where(x => x.Id > 12350).ToList();                          //Make List with lambda expresion for id > 12350
            
            foreach (Employee id in idList)                                                               //Loop to print
            {
                Console.WriteLine(id.firstName + " " + id.lastName + " " + id.Id);
            }
            Console.ReadLine();
        }
    }
}
