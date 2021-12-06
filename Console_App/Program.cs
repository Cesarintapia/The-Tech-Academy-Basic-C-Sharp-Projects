using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App
{
    class Program
    {
        static void Main(string[] args)
        {

            //Start section of the First Assigment "ONE DIMENSIONAL STRING'S ARRAY".

            Console.WriteLine("First assigment\"ONE DIMENSIONAL STRING'S ARRAY\"");
            string[] stringArray = new string[10];                                                     //Declare the array and inizializing.
            stringArray[0] = "I visited \"Hawaii\"     and I want to visit ";                          //Add string values in the follow lines (stringArray).
            stringArray[1] = "I visited \"Mexico\"     and I want to visit ";
            stringArray[2] = "I visited \"London\"     and I want to visit ";
            stringArray[3] = "I visited \"Brasilia\"   and I want to visit ";
            stringArray[4] = "I visited \"Munchen\"    and I want to visit ";
            stringArray[5] = "I visited \"La Havanna\" and I want to visit ";
            stringArray[6] = "I visited \"Milwakee\"   and I want to visit ";
            stringArray[7] = "I visited \"Oslo\"       and I want to visit ";
            stringArray[8] = "I visited \"Madrid\"     and I want to visit ";
            stringArray[9] = "I visited \"Abu Dabbi\"  and I want to visit ";

            Console.WriteLine("Please write down the name of one the city that you want to visit");    //Print the asking cuestion, to write out the City name.
            string city = Console.ReadLine();                     //Save the user input in variable string "city".
            for (int i = 0; i < stringArray.Length; i++)          //Start function "for" for add the user input. 
            {
                stringArray[i] = stringArray[i] + city + ".";     //Add the user imput to the stringArray
            }
            foreach (string cityAdded in stringArray)             //Start the function foreach for read and print the array plus city added
            {
                Console.WriteLine(cityAdded);                     //Print the new strings in the array
            }
            Console.WriteLine();                                  //Just to separete two functions

            //End section of the First Assigment "ONE DIMENSIONAL STRING'S ARRAY".


            //Section of the Second Assigment "infinit loop".

            Console.WriteLine("Second assigment \"INFINITE LOOP\"");
            Console.WriteLine("VERY IMPORTANT!! write out the follow text: \"VIVA THE KING-LORO\"");  //Ask an string for start the loop
            string kingLoro = Console.ReadLine();                 //Save the string in "kingLoro"
            bool vivaKingLoro = true;                             //Set condition for make the loop
            do                                                    //Start the loop.
            {
                Console.WriteLine(kingLoro);                      //Print while condition is true 
            }
            while (!vivaKingLoro);                                //Stop printing (the error was not negate the boolean type variable "vivaKingLoro")
            Console.WriteLine();                                  //Just to separete two functions

            //End section of the Second Assigment "infinit loop".


            //Start section of the Tird Assigment "BUCLE WITH < OPERATOR".

            Console.WriteLine("Tird assigment \"LOOP WITH < OPERATOR\"");                  //Start tird assigment.
            Console.WriteLine("How many times do you want to say \"VIVA King-Loro\"");     //Ask to start printing "VIVA King-Loro".
            int lifeKingLoro = Convert.ToInt32(Console.ReadLine());                        //Conver the string to integer.
            for (int j = 0; j < lifeKingLoro; j++)                                         //Start loop "for" with operator "<".
            {
                Console.WriteLine("\"VIVA King-Loro\"");                                   //Print "lifeKingLoro" times.
            }
            Console.WriteLine();                                                           //Just to separete two functions

            //End section of the Tird Assigment "BUCLE WITH < OPERATOR".


            //Start section of the tird Assigment "BUCLE WITH <= OPERATOR".

            Console.WriteLine("How many times want to visit: " + city);                    //Print asking (using the array in the first assigment)
            int timesVisit = Convert.ToInt32(Console.ReadLine());                          //Convert the user input in integer

            for (int j = 0; j <= timesVisit - 1; j++)                                      //Start the Loop with <= operator
            {
                stringArray[j] = stringArray[j] + " You can say that.";                    //Calling the stringArray from the first assigment
                Console.WriteLine(stringArray[j]);                                         //Print just the times that the user set.
            }
            Console.WriteLine();                                                           //Just to separete two functions

            //End section of the tird Assigment "BUCLE WITH <= OPERATOR".


            //Start section of the Four Assigment "List of strings".

            List<string> countryList = new List<string>();                                 //Start the list and call it countryList
            countryList.Add("Mexico");                                                     //add countris to the list
            countryList.Add("Estados Unidos");
            countryList.Add("Holanda");
            countryList.Add("Nicaragua");
            countryList.Add("Colombia");
            countryList.Add("China");
            countryList.Add("Katar");
            countryList.Add("Sudafrica");

            Console.WriteLine("Please, write out the name of one country");                //Ask to find a country
            string country = Console.ReadLine();                                           //Save the user input in country
            bool elcountry = false;                                                        //Create boolean flag 
            for (int k = 0; k < countryList.Count; k++)
            //foreach (string theCountry in countryList)                                     //Start the revision of the countryList
            {
                if (countryList[k].Contains(country))
                {
                    Console.WriteLine(country + ", it's on the list");
                    Console.WriteLine(k);
                    elcountry = true;                                                      //Defining th boolean flag if the country in find it in countryList
                }
            }
            if (elcountry == false)                                                                 //if the boolean flag is in the countryList, it continue false the uses the step
            {
                Console.WriteLine(country + ", it isn't on the list");                         //Print the result
            }
            
             //End section of the Four Assigment "List of strings".


            //Start section of the Five Assigment "List of strings with elements repited".

            List<string> lakeList = new List<string>();                       //start the list 
            lakeList.Add("Patzcuaro");                                        //Fill the list with repited elements 
            lakeList.Add("Oswego");
            lakeList.Add("Oswego");
            lakeList.Add("Oso");
            lakeList.Add("Titikaca");
            lakeList.Add("Oswego");
            lakeList.Add("Como");
            lakeList.Add("Oso");

            Console.WriteLine("Please, write out the name of one lake");      //Ask for the name of one element in the list
            string lake = Console.ReadLine();                                 //Set the element in the variable "lake"
            bool ellake = false;
            for (int w = 0; w < lakeList.Count; w++)                          //Start the revision of the list from 0 until the size of the list
            {
                if (lakeList[w].Contains(lake))                               //If, rewiev if "lake" is contained in the lake list using "lakeList.Contains" 
                {
                    Console.WriteLine(lakeList[w]);                           //Print the name of the repited element
                    Console.WriteLine(w);                                     //Print the index of the repited element
                    ellake = true;
                }
            }
            if (ellake == false)                                              //if "ellake" is false
            {
                Console.WriteLine(lake + " It isn't in the List");            //Print it that lake isn't in the list.
            }
            Console.WriteLine();

            //End section of the Five Assigment "List of strings with elements repited".


            //Start section of the Six Assigment "List of strings with elements repited and look them".
            //I use the list made in the five assignment
            Console.WriteLine("Do you want to check over the list of lakes press enter: ");
            Console.ReadLine();
            List<string> buff = new List<string>();                                    //create a empty list to compare the elements with the previous list of lakes
            foreach (string thelake in lakeList)                                       //Start the revision of "lakeList"
            {
               if (buff.Contains(thelake))                                             //Star the function to compare the "lake" in the empy list
                {
                    Console.WriteLine(thelake + " already has appers in the list");    //If find it print it
                }
                else
                {
                    buff.Add(thelake);                                                 //If not find it, add in the empy list
                    Console.WriteLine(thelake + " hasn't appers in the list");         //Then print, the list has not contain "lake"
                }
            }
            Console.ReadLine();

            //End section of the six Assigment "List of strings with elements repited and look them".
        }
    }
}
