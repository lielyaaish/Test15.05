using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameTestPart4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Hangman Game! ");

            Random rnd = new Random();

            string[] Famous = 
            {
                "Noa Kirel", "Jhonatan Mergui", "Barak Obama", "Justin Bieber", "Demi Lovato", "Miley Cyrus",
                "Lady Gaga", "Bruno Mars", "Chris Brown", "Jason Derulo", "Sia", "Static and Ben-El", "Stephan"
            };

            int NumberOfLives = 10;
            bool Winning = false;
            int GuessingLetters = 0;
            string input;
            char guess;

            string wordToGuess = Famous[rnd.Next(0, Famous.Length)];
            string wordToGuessUppercase = wordToGuess.ToUpper();

            StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length);
            for (int i = 0; i < wordToGuess.Length; i++)
                displayToPlayer.Append("-");

            // List of the Number of chars guessing
            List<char> correctGuesses = new List<char>();
            List<char> incorrectGuesses = new List<char>();

            while (!Winning && NumberOfLives > 0)
            {
                Console.WriteLine("Guess ONE Letter: ");
                Console.Write("A) ");
                input = Console.ReadLine().ToUpper();
                guess = input[0];

                if (correctGuesses.Contains(guess))
                {
                    Console.WriteLine($"You've already tried {guess}, and it was correct!");
                }
                else if (incorrectGuesses.Contains(guess))
                {
                    Console.WriteLine($"You've already tried {guess}, and it was wrong!");
                }

                if (wordToGuessUppercase.Contains(guess))
                {
                    correctGuesses.Add(guess);

                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuessUppercase[i] == guess)
                        {
                            displayToPlayer[i] = wordToGuess[i];
                            GuessingLetters++;
                        }
                    }

                    if (GuessingLetters == wordToGuess.Length)
                        Winning = true;
                }
                else
                {
                    incorrectGuesses.Add(guess);
                    Console.WriteLine($"There is no {guess} in the word!", guess);
                    NumberOfLives--;
                    Console.WriteLine($"You have left {NumberOfLives} Lives!");
                }

                Console.WriteLine(displayToPlayer.ToString());
                Console.WriteLine();
            }

            if (Winning)
            {
                Console.WriteLine("You guess the word :) !!");
            }
            else
            {
                Console.WriteLine("You lost! SORRY..... ");
            }

            Console.WriteLine("Thank you for playing.... !! :)");

            //I didn't know how to restart the game, i thought to do all of this in one function but i'm getting error
            /*
            BY THE WAY this line i took from the internet because i didn't know how to put - instand of the letter (:
             StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length);
            for (int i = 0; i < wordToGuess.Length; i++)
                displayToPlayer.Append("-");
             */
        }
    }
}
 