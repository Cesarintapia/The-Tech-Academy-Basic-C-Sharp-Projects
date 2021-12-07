using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_method_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Intmath operationmathematic = new Intmath();                           //Instance the class "Inmath"

            Console.WriteLine(" Pick one number: ");                               //Ask for number
            int numeMath1 = Convert.ToInt32(Console.ReadLine());                   //Conver to integer
            int resultado1 = operationmathematic.OperaMath(numeMath1);             //Make the operation
            Console.WriteLine(resultado1);

            Console.WriteLine(" Pick one number: ");                                //Ask for number
            decimal numeMath2 = Convert.ToInt32(Console.ReadLine());                //Convert to decimal for be able to make the operation
            int resultado2 = operationmathematic.OperaMath(numeMath2);              //Make the operation
            Console.WriteLine(resultado2);

            Console.WriteLine(" Write out something: ");                            //Ask for string
            string stringMath = Console.ReadLine();                                 //Save the input in string variable "stringMath"
            int resultado3 = operationmathematic.OperaMath(stringMath);             //Make the operation when is possible
            Console.WriteLine(resultado3);


            Console.ReadLine();
        }
    }
}
