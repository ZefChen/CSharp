//Modify your console application to display a different message. Go ahead and
//intentionally add some mistakes to your program, so you can see what kinds of error
//messages you get from the compiler. The more familiar you are with these messages, and
//what causes them, the better you'll be at diagnosing problems in your programs that you /
//didn't/ intend to add!

//Using just the ReadLine and WriteLine methods and your current knowledge of variables,
//you can have the user pass in quite a few bits of information. Using this approach, create a
//console application that asks the user a few questions and then generates some custom
//output for them. For instance, your program could generate their "hacker name" by asking
//them their favorite color, their astrology sign, and their street address number. The result
//might be something like "Your hacker name is RedGemini480."


using System;
namespace Assignment1
{
    public class ConsoleWriteRead
    {
       public static void Interaction1()
        {
            Console.WriteLine("Welcome to this line of code. What's your favortite color?");
            string ucolor = Console.ReadLine();
            Console.WriteLine($"{ucolor}, great choice. What's your astrology sign?");
            string uast = Console.ReadLine();
            Console.WriteLine($"Oh, {uast}, I can see who you are now.\n " +
                $"What's your street address number?");
            int ustrnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"I see, it's No.{ustrnum}.\n " +
                $"Your hacker name is {ucolor}{uast}{ustrnum}");
        }
    }
}

