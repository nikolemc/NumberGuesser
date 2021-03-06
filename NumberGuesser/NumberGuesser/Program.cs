﻿using System;
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

            //Level 2
            //When you display the past guesses to the screen, you should display whether or not they are too high or too low
            //If you guess the same number twice, the program should ask you if you're feeling all right (or something similarly sarcastic).


            //Random random = new Random();
            //int randomNumber = random.Next(0, 100);

            //Console.WriteLine("Guess a number between 1 and 100?:");
            //string line = Console.ReadLine();


            Random random = new Random();
            int randomNumber = random.Next(1, 100);
            int guess;
            string UserGuesses;
            int counter = 0;
            var GuessValues = new int[5];
            UserGuesses = "";
            bool duplicateGuess;



            Console.WriteLine($"shhh don't tell anyone but the answer is {randomNumber}");
            Console.WriteLine("Guess a number between 1 and 100?:");
            var input = Console.ReadLine();
            bool correct = int.TryParse(input, out guess);


            do
            {
                Console.Write("Guess: ");
                Console.WriteLine(guess);

                if (counter > 0)
                {
                    duplicateGuess = false;

                    for (int i = 0; i < counter; i++)
                    {

                       if (GuessValues[i] == guess)
                        {
                            duplicateGuess = true;
                        }
                    }

                    if  (duplicateGuess == true)
                    {
                        Console.WriteLine("You already used this number! Are you feeling all right?");
                        Console.WriteLine("Try again:");
                        input = Console.ReadLine();
                        int.TryParse(input, out guess);
                    }
                }


                GuessValues[counter] = guess;
                          

                if (guess != randomNumber)
                {
                    
                    if (counter >= 4)
                    {
                        // Console.WriteLine($"You Lose! The answer was {randomNumber}. Your guesses were: " + UserGuesses);
                        Console.WriteLine("You Lost! Your guesses were:");


                        for (int i = 0; i <= counter; i++)

                        {
                            if (GuessValues[i] < randomNumber)
                            {
                                Console.WriteLine($"{GuessValues[i]}: too low");
                            }

                            if (GuessValues[i] > randomNumber)
                            {
                                Console.WriteLine($"{GuessValues[i]}: too high");
                            }

                        }

                        Console.ReadLine();


                    }
                         
                    else if (guess > randomNumber)
                    {

                        Console.WriteLine($"You guessed {guess}. The number I'm thinking of is lower.");
                        Console.WriteLine("Try again:");
                        input = Console.ReadLine();
                        int.TryParse(input, out guess);




                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine($"You guessed {guess}. The number I'm thinking of is higher.");
                        Console.WriteLine("Try again:");
                        input = Console.ReadLine();
                        int.TryParse(input, out guess);
                    }



                }


                counter++;
            }
            while (guess != randomNumber && counter < 5);

            if (guess == randomNumber)
            {
                //counter++;
                Console.WriteLine("Congratulations you win, you must be a mind reader!");
                Console.ReadLine();
                //input = Console.ReadLine();
                //int.TryParse(input, out guess);
            }


        }
    }
}