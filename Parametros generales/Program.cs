using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parametros_generales
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> listOfThings1 = new Employee<string>();                               //Instantiate an Employee object with type “string” as its generic parameter
            listOfThings1.things = new List<string> { "Autumalis", "Oratrix", "Guatemalae" };      //Assign a list of strings as the property value of Things

            Employee<int> listOfThings2 = new Employee<int>();                                     //Instantiate an Employee object with type “int” as its generic parameter 
            listOfThings2.things = new List<int> { 1, 2, 3 };                                      //Assign a list of integers as the property value of Things.

            foreach (string thing1 in listOfThings1.things)                                        //Print one List
            {
                Console.WriteLine(thing1);

            };
            for (int i=0; i<3; i++)                                                                //Print both Lists matching.
            {
                Console.WriteLine(listOfThings1.things[i] + ": " + listOfThings2.things[i]);
            }

            Console.ReadLine();
        }
    }
}
