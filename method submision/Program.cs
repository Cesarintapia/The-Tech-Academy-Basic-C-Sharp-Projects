using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_submision
{
    class Program
    {
        static void Main(string[] args)
        {
            Newmath newmath = new Newmath();                                               //Instancing the class in "newmath"

            Console.WriteLine("Pick one numbers then press enter");                        //Ask the user to imput one number
            int chuvaca1 = Convert.ToInt32(Console.ReadLine());                            //Save the number in "chuvaca" integer type variable
            Console.WriteLine("Pick other numbers then press enter or just press enter");  //Ask the user to imput one number or just press enter
            string elchuvaca = Console.ReadLine();                                         //save the input in string type variable.

            if (String.IsNullOrEmpty(elchuvaca))                                           //compare if the string is null type and validate
            {
                Console.WriteLine(newmath.Laoperationmath(chuvaca1));                      //Perform the operation calling the object and its method and print it
            }
            else
            {
                int chuvaca2 = Convert.ToInt32(elchuvaca);                                 //if "elchuvaca" is a number, validate with the integer type variable "chuvaca2"
                int leresult = newmath.Laoperationmath(chuvaca1, chuvaca2);                //Perform the operation calling the object and its method and print it
                Console.WriteLine(leresult);
            }
            Console.ReadLine();
        }
    }
}
