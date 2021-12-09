using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_class
{
    public abstract class Person                                                    //Create an abtrac Class called "Person".
    {
        public string firstName { get; set; }                                      //Asing the property firstName.
        public string lastName { get; set; }                                       //Asing the property lastName.
        public virtual void SayName()                                              //Create a virtual void method called "SayName". 
        {
            //Console.WriteLine("m person. Name: " + firstName + " " + lastName);    //The method prints and calls propierties.
        }
    }
}
