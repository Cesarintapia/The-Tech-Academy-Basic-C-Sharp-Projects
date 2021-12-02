using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_app_species
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            bool theKingLoroGame= true;  //declare the variable boolean to start "while" 
           
            while (theKingLoroGame) //start while, while theKingLoroGame be true
            {
                Console.WriteLine("\nDo you want to know the King-Loro Specie? \"true\" or \"false\""); //Ask if you want to participate
                bool playKingLoro = Convert.ToBoolean(Console.ReadLine()); //Convert the aswer to boolean

                if (playKingLoro == true) //start "if", if  the answer playKingLoro is true
                {
                    Console.WriteLine("Welcome to the Kingdom of King-Loro"); // Print welcome
                    theKingLoroGame = true; 
                    Console.WriteLine("The Parrot's Specie");  //print title
                    Console.WriteLine("I'm Green, my head is: in the top blue, in the chics yellow, in may front red, \n my beak and tongue is dark"); //print description
                    Console.WriteLine("Guess the parrot's specie: \"Autumalis\", \"Oratrix\", \"Guatemalae\""); //Ask the Specie
                    string parrotSpecie = Console.ReadLine(); //the Specie is readed in save in the string
                    bool rigthSpecie = parrotSpecie == "Autumalis"; //convert the string in boolean and asignin iguality

                    do                                  //start do
                    {
                        switch (parrotSpecie)               //searching the rigth specie
                        {
                            case "Oratrix":   //first case wrong
                                Console.WriteLine("You say Oratrix. Try again.");
                                Console.WriteLine("Guess the parrot's specie: \"Autumalis\", \"Oratrix\", \"Guatemalae\"");
                                parrotSpecie = Console.ReadLine();
                                break;
                            case "Autumalis": //Second case rigth
                                Console.WriteLine("You are Right. I'm an Autumalis.");
                                rigthSpecie = true;
                                break;
                            case "Guatemalae": //Tird case wrong
                                Console.WriteLine("You say Guatemalae. Try again.");
                                Console.WriteLine("Guess the parrot's specie: \"Autumalis\", \"Oratrix\", \"Guatemalae\"");
                                parrotSpecie = Console.ReadLine();
                                break;
                            default: //if you don't write correctly, must to repeat
                                Console.WriteLine("You need to study ortography in the King-Loro School");
                                Console.WriteLine("Guess the parrot's specie: \"Autumalis\", \"Oratrix\", \"Guatemalae\"");
                                parrotSpecie = Console.ReadLine();
                                break;
                        }
                    }
                    while (!rigthSpecie); // to escape to do
                }

                else if (playKingLoro == false) // if the aswer is no to play start this process
                {
                    Console.WriteLine("Hasta la vista baby");
                    theKingLoroGame = false;
                }

            }
            Console.ReadLine();

        }
    }
}
