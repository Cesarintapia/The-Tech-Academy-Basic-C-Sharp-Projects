using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismJob
{
    public abstract class Person                                                                         //Create a class Person
    {
        public string FirstName { get; set; }                                           //Set one property call "FirstName"
        public string LastName { get; set; }                                            //Set one property call "LastName".

        

        public virtual void SayName()                                                   //Create a void method call "SayName". 
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);                  //Perform the method.
        }


    }
}
