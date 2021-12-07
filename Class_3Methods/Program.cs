using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_3Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write out a number for math operations: ");            // Ask the user pick a number
            int lenumero = Convert.ToInt32(Console.ReadLine());                       // Save the number in the integer type "leresult1"

            Lamath lamathObject = new Lamath();                                       //Create an instance the la Class Lamath.
            int leresult1 = lamathObject.operation1(lenumero);                        //Save the number in the integer type "leresult2"
            Console.WriteLine(leresult1);                                             //Print the result

            int leresult2 = lamathObject.operation2(lenumero);                        // Save the number in the integer type "leresult2"
            Console.WriteLine(leresult2);                                             //Print the result

            int leresult3 = lamathObject.operation3(lenumero);                        // Save the number in the integer type "leresult2"
            Console.WriteLine(leresult3);                                             //Print the result

            Console.ReadLine();
        }
    }
}
