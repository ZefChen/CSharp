﻿//1.FizzBuzzis a group word game for children to teach them about division.
//Players take turns to count incrementally, replacing any number divisible by three
//with the word /fizz/, any number divisible by five with the word /buzz/,
// and any number divisible by both with /fizzbuzz/.
//Create a console application in Chapter03 named Exercise03 that outputs a simulated
//FizzBuzz game counting up to 100. The output should look something like the following
using System;
namespace Assignment2
{
    public class Exercise3
    {
        public static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i += 1)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
