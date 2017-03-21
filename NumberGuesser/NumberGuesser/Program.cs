using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Level 1
            //Generate a random number between 1 and 100
            //Prompt the user for a guess
            //If the guess is less than the program's number, it should tell you that you were low and let you guess again.
            //If the guess is greater than the program's number, it should tell you that you were high and let you guess again.
            //If the guess is correct, the program should tell you that you win and then quit.
            //After 5 incorrect guesses, the program should tell you that you lose.
            //You should display all the guesses to the screen

            Random random = new Random();
            int randomNumber = random.Next(0, 100);

            Console.WriteLine("Guess a number between 1 and 100?:");
            string line = Console.ReadLine();
         

          


        }
    }
}
