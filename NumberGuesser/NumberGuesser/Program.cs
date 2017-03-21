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

            //Random random = new Random();
            //int randomNumber = random.Next(0, 100);

            //Console.WriteLine("Guess a number between 1 and 100?:");
            //string line = Console.ReadLine();


            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            int guess;
           // string guessString = "";
            int counter = 0;
            int[] guessvalues = new int[5];
           


            Console.WriteLine($"shhh don't tell anyone but the answer is {randomNumber}");
            Console.WriteLine("Guess a number between 1 and 100?:");
            var input = Console.ReadLine();
            bool correct = int.TryParse(input, out guess);

            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine($"You guessed = {guessvalues[i]}");
            }


            do
            {
                Console.Write("Guess: ");
                Console.WriteLine(guess);



                if (guess > randomNumber)
                {
                    counter++;
                    Console.WriteLine($"You guessed {guess}. The number I'm thinking of is lower.");
                    Console.WriteLine("Try again:");
                    input = Console.ReadLine();
                    int.TryParse(input, out guess);

                    


                }
                else if (guess < randomNumber)
                {
                    counter++;
                    Console.WriteLine($"You guessed {guess}. The number I'm thinking of is higher.");
                                       
                    input = Console.ReadLine();
                    int.TryParse(input, out guess);
                }

                else if (guess == randomNumber)
                {
                    //counter++;
                    Console.WriteLine("Congratualtions you win, you must be a mind reader!");
                    Console.ReadLine();
                    //input = Console.ReadLine();
                    //int.TryParse(input, out guess);

                }

                else if (counter > 6)
                {
                    Console.WriteLine("You Lose!");
                
                    Console.ReadLine();
                    

                }

                

            }
            while (guess != randomNumber && counter < 5);







        }
    }
}