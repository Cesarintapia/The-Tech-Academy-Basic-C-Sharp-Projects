using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorphismJob
{
    public class Employee : Person, IQuitable                     //Set heritages from Person class and IQuitable Interface, to the class Employee 
    {

        public override void SayName()                    //Override the method SayName.
        {
            base.SayName();                               //Using the method SayName.
            Console.WriteLine("m employee. Name: ");      //Creating new print overrring.
        }
        public void Quit()                               //Calling the "Quit" method and set "public"
        {
            Console.WriteLine("quit employee Name: " + this.FirstName + this.LastName);   //Perform the function of the method
        }
        



    }
}
