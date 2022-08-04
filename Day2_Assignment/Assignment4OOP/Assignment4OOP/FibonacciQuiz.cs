//The Fibonacci sequence is a sequence of numbers where the first two numbers are 1 and 1,
//and every other number in the sequence after it is the sum of the two numbers before it. So
//the third number is 1 + 1, which is 2. The fourth number is the 2nd number plus the 3rd,
//which is 1 + 2. So the fourth number is 3. The 5th number is the 3rd number plus the 4th
//number: 2 + 3 = 5.This keeps going forever.
//The first few numbers of the Fibonacci sequence are: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, ...
//Because one number is defined by the numbers before it, this sets up a perfect
//opportunity for using recursion.
//Your mission, should you choose to accept it, is to create a method called Fibonacci, which
//takes in a number and returns that number of the Fibonacci sequence. So if someone calls
//Fibonacci(3), it would return the 3rd number in the Fibonacci sequence, which is 2. If
//someone calls Fibonacci(8), it would return 21.
//In your Mainmethod, write code to loop through the first 10 numbers of the Fibonacci
//sequence and print them out.
//Hint #1:Start with your base case. We know that if it is the 1st or 2nd number, the value will
//be 1.
//Hint #2:For every other item, how is it defined in terms of the numbers before it? Can you
//come up with an equation or formula that calls the Fibonaccimethod again?
using System;
namespace Assignment4OOP
{
    public class FibonacciQuiz
    {
        public int I { get; set; }

        public static int Fibonacci(int I)
        {
            int a = 1;
            int b = 1;
            List<int> fbn = new List<int>();
            fbn.Add(a);
            fbn.Add(b);
            if (I == 1 || I == 2)
            {
                return 1;
            }
            else
            {
                for (int n = 2; n < I; n += 1)
                {
                    int next = fbn[n - 2] + fbn[n - 1];
                    fbn.Add(next);
                }
                return fbn[I-1];
            }
        }
    }
}

