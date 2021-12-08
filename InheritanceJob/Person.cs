using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceJob
{
    class Person                                                           //Create a class Person
    {
        public string FirstName;                                           //Set one property call "FirstName"
        public string LastName;                                            //Set one property call "LastName".

        public void SayName()                                              //Create a void method call "SayName". 
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);      //Perform the method.
        }

    }
}
