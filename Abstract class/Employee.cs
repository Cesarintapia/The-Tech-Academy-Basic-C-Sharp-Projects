using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismJob
{
    public class Employee : Person, IQuitable                                                      //Inherit from Person Class to Employee class.
    {

        public override void SayName()                                                 //Override the method SayName.
        {
            base.SayName();                                                            //Using the method SayName.
            Console.WriteLine("m employee. Name: " + firstName + " " + lastName);      //Creating new print overrring.
        }
        public void Quit(IQuitable quitable)
        {
            throw new NotFiniteNumberException();

            Console.WriteLine("q employee. Name: " + firstName + " " + lastName);

        }

    }
}
