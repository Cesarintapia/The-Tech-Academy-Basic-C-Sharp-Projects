using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BRANCHING_SUBMISSION_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t Welcome to Package Express. Please follow the instructions below."); //Print title

            Console.WriteLine("\tPlease enter the package weight:"); //Ask for weight
            int weightPackage = Convert.ToInt32(Console.ReadLine()); //Convert weight to integer "weightPackage"

            if (weightPackage > 50) //Clausule to weightPackage no more tha 50
            {
                Console.WriteLine("Sorry!!. Package too heavy to be shipped via Package Express. Have a good day."); // if weightPackage more tha 50, print this message
            }
            //Section to calculate dimensions and volumen. 
            Console.WriteLine("\tPlease enter the package width:"); //Ask width
            int widthPackage = Convert.ToInt32(Console.ReadLine()); //Convert to integer  widthPackage
            Console.WriteLine("\tPlease enter the package height:"); //Ask heigth
            int heightPackage = Convert.ToInt32(Console.ReadLine()); //Convert to integer heightPackage
            Console.WriteLine("\tPlease enter the package length:"); //Ask length
            int lengthPackage = Convert.ToInt32(Console.ReadLine()); //Convert to integer lengthPackage
            int dimensions = widthPackage + heightPackage + lengthPackage; //Calculate dimensions
            int volumen= widthPackage * heightPackage * lengthPackage; //calculate volumen

            if (dimensions > 50) //Clausule to dimensions no more tha 50
            {
                Console.WriteLine("Sorry!!. Package too big to be shipped via Package Express. Have a good day."); // if dimensions more tha 50, print this message
            }

            double priceShipping = (volumen * weightPackage) / 100; // Opetation for calculate price
            Console.WriteLine("\tYour estimated total for shipping this package is: " + priceShipping + "\n\tThanks You!!"); //Print total price of shipping
            Console.ReadLine();
        }
    }
}
