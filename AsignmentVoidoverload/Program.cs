using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignmentVoidoverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Mathbytwo mathbytwo = new Mathbytwo();                           //Instancing the Class Mathbytwo

            Console.WriteLine("Please pick a number: ");                     //Ask for a user nunber
            int lenumero1 = Convert.ToInt32(Console.ReadLine());             //Convert the input in integer type variable and save in "lenumero1".
            mathbytwo.MathbyParrotsLine(lenumero1);                          //Call the method "MathbyParrotsLine" using the input "lenumero1".

            mathbytwo.MathbyParrotsLine1(lenumero1, out int chuvaca);        //Call the method "MathbyParrotsLine" using the input "lenumero1", and the output parameter "chuvaca".
            Console.WriteLine(chuvaca - 1000);                               //Print the ouput parameter and performing operation math (just to make visible)

            MathByTwoStatic.MathbyParrotsLine2(lenumero1);                   //Call the static method "MathbyParrotsLine" from the MathByTwoStatic class and using the input "lenumero1"

            Console.ReadLine();



        }
    }
}
