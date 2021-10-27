using System;
using System.Collections.Generic;

namespace BlockbusterLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing the blockbuster class.
            Blockbuster blockbuster = new Blockbuster();

            //Calling the Movie Class and assigning it a new variable and then calling the CheckOut Method inside the Blockbuster class and it displays the movie the user selected
            Movie selectedMovie = blockbuster.CheckOut();

            Console.WriteLine("Do you want to watch the movie? y/n");
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "y" || userInput == "yes")
            {
                selectedMovie.Play();
            }
            else
            {
                Console.WriteLine("Okay! Have a nice day!");
            }
            
        }
    }
}


//Grab or fork some else's repo for the Blockbuster lab
//Rework the Blockbuster lab to use an abstract class and an abstract play() method
//Test their code, try to find input that break and present the original with a list of inputs that broke their code

//Oh oh one extended Exercise:
//4.include a Genre Enum if the person hasn't already
