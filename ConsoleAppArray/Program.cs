using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Section of one dimensional string array
            string[] stringArray = new string[5];                        //Declare the array and inizializing.
            stringArray[0] = "0. Hawaii. \"Haloha\"";                   //Add values in the follow 5 lines, for all the index (1-8)
            stringArray[1] = "1. Mexico \"Buenos Dias\"";
            stringArray[2] = "2. China \"Ni Hao\"";
            stringArray[3] = "3. Brasil \"Bom Dia\"";
            stringArray[4] = "4. Germany \"Guten Morguen\"";

            Console.WriteLine("Do you Know how to say Good Mornig in diferent languages?..Select one number from 0-4");     //Print the asking cuestion, to select the number
            int selection = Convert.ToInt32(Console.ReadLine());    //Save the input in variable int "selection".
            string hiSelection = stringArray[selection];           //asingning in "hiSelection" the index selected
            Console.WriteLine("You Select: " + hiSelection);      //Print the selectetion user, using hiSelection.


            //Section of one dimensional array
            int[] numArray = new int[9];        //Declare the array and inizializing.
            numArray[0] = 0;                   //Add values in the follow 9 lines, for all the index (1-8)
            numArray[1] = 1;                    
            numArray[2] = 2;
            numArray[3] = 3;
            numArray[4] = 4;
            numArray[5] = 6;
            numArray[6] = 6;
            numArray[7] = 7;
            numArray[8] = 8;

            Console.WriteLine("Hey.. Now Select a number from 0 to 8, One Number is wrong");     //Print the asking cuestion, to select the number
            int number = Convert.ToInt32(Console.ReadLine());          //Convert the input in integer and save it in "number"
            int numberSelected = numArray[number];                    //Save the input integer in "numberSelected"
            Console.WriteLine("You Select: " + numberSelected);      //Print the selected number.

            List<string> intList = new List<string>();     //Declare the list and inizializing.
            intList.Add("Autumalis");                     //Set values for each string in the follow lines
            intList.Add("Guatemalae");
            intList.Remove("Oratrix");

            Console.WriteLine("One more please, select one number from 0-2 and King Loro Family is here");     //Print the asking cuestion, to select the number (0-2)
            int loroSelection = Convert.ToInt32(Console.ReadLine());          //Convert in integer the selection
            Console.WriteLine(intList[loroSelection]);                        //Set the selection and print it.
            
            Console.ReadLine();

        }
    }
}
