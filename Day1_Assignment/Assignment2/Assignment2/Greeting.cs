//Write a program that greets the user using the appropriate greeting for the time of day.
//Use only if , not else or switch , statements to do so. Be sure to include the following
//greetings:
//"Good Morning"
//"Good Afternoon"
//"Good Evening"
//"Good Night"
//It 's up to you which times should serve as the starting and ending ranges for each of the
//greetings.If you need a refresher on how to get the current time, see DateTime
//Formatting. When testing your program, you'll probably want to use a DateTime variable
//you define, rather than the current time. Once you're confident the program works
//correctly, you can substitute DateTime.Now for your variable (or keep your variable and just
//assign DateTime.Now as its value, which is often a better approach)
using System;
namespace Assignment2
{
    public class Greeting
    {
        public static void Greet()
        {
            DateTime d = DateTime.Now;

            int hour = d.Hour;

            if (hour > 6 & hour < 12)
            {
                Console.WriteLine("Good Morning");
            }
            else if (hour > 12 & hour < 18)
            {
                Console.WriteLine("Good afternoon");
            }
            else if (hour > 18 & hour < 21)
            {
                Console.WriteLine("Good evening");
            }
            else
            {
                Console.WriteLine("Good Night");
            }

        }
    }
}

