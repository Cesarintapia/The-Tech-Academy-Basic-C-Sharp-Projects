using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            MathWithVoid mathwithVoid = new MathWithVoid();                                   //Instancing the class in "mathwithVoid" object

            Console.WriteLine("Calling the void method passing two numbers");                 //Print message to the King-Loro fans
            mathwithVoid.MathParrot(19, 213);                                                 //Call the method in the class, passing in two numbers,
                                                                                               

            Console.WriteLine("Calling the void method specifying the parameters by name.");  //Other message for the King-Loro fans
            mathwithVoid.MathParrot(number1:200, number11:166);                               //Call the method in the class, specifying the parameters by name.


            Console.ReadLine();

        }
    }
}
