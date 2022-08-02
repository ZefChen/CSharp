//Your program can create a random number between 1 and 3 with the following code:
//int correctNumber = new Random().Next(3) + 1;
//Write a program that generates a random number between 1 and 3 and asks the user to
//guess what the number is. Tell the user if they guess low, high, or get the correct answer.
//Also, tell the user if their answer is outside of the range of numbers that are valid guesses
//(less than 1 or more than 3). You can convert the user's typed answer from a string to an
//int using this code:
//int guessedNumber = int.Parse(Console.ReadLine());
//Note that the above code will crash the program if the user doesn't type an integer value.
//For this exercise, assume the user will only enter valid guesses.
using System;
namespace Assignment2
{
    public class GuessNumber
    {
        public static void guessgame()
        {
            Console.Write("Guess a Number.");
            int guessedNumber = int.Parse(Console.ReadLine());
            int correctNumber = new Random().Next(3) + 1;
            if (guessedNumber <= 0 || guessedNumber >= 4)
            {
                Console.WriteLine("Your guess is out of the league.");
            }
            else
            {
                if (guessedNumber < correctNumber)
                {
                    Console.WriteLine("Your guess is too small.");
                }
                else if (guessedNumber > correctNumber)
                {
                    Console.WriteLine("Your guess is too big.");
                }
                else
                {
                    Console.WriteLine("You are correct");
                }
            }

        }
    }
}

