//Write a program that prints the result of counting up to 24 using four different increments.
//First, count by 1s, then by 2s, by 3s, and finally by 4s.
//Use nested for loops with your outer loop counting from 1 to 4. You inner loop should
//count from 0 to 24, but increase the value of its /loop control variable/ by the value of the /
//loop control variable/ from the outer loop. This means the incrementing in the /
//afterthought/ expression will be based on a variable.
//Your output should look something like this:
//0,1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24
//0,2,4,6,8,10,12,14,16,18,20,22,24
//0,3,6,9,12,15,18,21,24
//0,4,8,12,16,20,24
using System;
namespace Assignment2
{
    public class CountTo24
    { 
        public static void Count()
        {
            int c, i;
            for (c = 1; c <= 4; c++)
            {
                for (i = 0; i < 24; i = i + c)
                {
                    Console.Write(i + ", ");
                }
                Console.WriteLine("24\n");
            }

        }

    }
}

