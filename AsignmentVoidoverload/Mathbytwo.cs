using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsignmentVoidoverload
{
    class Mathbytwo
    {
        public void MathbyParrotsLine(int lenumero)                            //Defining the public void method as "MathbyParrotsLine", type integer.
        {
            int leresult = lenumero / 2;                                       //Performing what the method do. 
            Console.WriteLine(leresult);                                       //Print result from the method.
        }
        public void MathbyParrotsLine1(int lenumero, out int lenumeroOut)      //Defining the public void method as "MathbyParrotsLine1", with one parametrer as a integer type variable type,
        {                                                                      //and other output parameter by the same type. 
            lenumeroOut = lenumero / 2;                                        //Perform operation and the result is the output from the variable "lenumeroOut"
        }
        public int MathbyParrotsLine1(string stringInput)                      //Overloding the public method "MathbyParrotsLine1" using string type varible.
        {
            int leresult = Convert.ToInt32(stringInput) / 2;                   //Perform one math operation using this method, (forcing the string like a integer)
            return leresult;
        }
    }
}
