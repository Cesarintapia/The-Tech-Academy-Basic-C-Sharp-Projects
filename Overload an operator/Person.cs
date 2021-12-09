using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overload_an_operator
{
    public abstract class Person                                              //Create an abstract class Person.
    {
        public string FirstName { get; set; }                                 //Set one property call "FirstName"
        public string LastName { get; set; }                                  //Set one property call "LastName".
        
        public List<Person> Persons { get; set; }

        public virtual void SayName()                                        //Create a void method call "SayName". 
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);        //Perform the method.
        }


    }
}
