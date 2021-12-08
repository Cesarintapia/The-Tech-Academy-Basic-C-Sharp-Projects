using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignmentVoidoverload
{
    class MathByTwoStatic
    {
        public static int MathbyParrotsLine2(int numero)                       //Defining the public static method as "MathbyParrotsLine2" using integer type variable. 
        {
            Console.WriteLine(numero);                                         //Printing the parametro.
            int leresult = numero * 89;                                        //Perform a math operation.
            return leresult;                                                   //Set to return the result call "leresult".
        }
    }
}
