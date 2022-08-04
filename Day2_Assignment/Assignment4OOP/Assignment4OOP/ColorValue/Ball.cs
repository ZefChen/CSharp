//Create a Ball class:
//The Ball class should have instance variables for size and color (the Color class you just
//created). Let’s also add an instance variable that keeps track of the number of times it
//has been thrown.
//Create any constructors you feel would be useful.
//Create a Pop method, which changes the ball’s size to 0.
//Create a Throw method that adds 1 to the throw count, but only if the ball hasn’t been
//popped (has a size of 0).
//A method that returns the number of times the ball has been thrown.
using System;
namespace Assignment4OOP.ColorValue
{
    public class Ball : Color
    {
        public int Size { get; set; }

        private int ThrowTime;

        public Ball(int size, int red, int green, int blue) : base(red, green, blue)
        {
            if (red < 256 && red >= 0 && green < 256 & green >= 0
                && blue < 256 && blue >= 0 && size > 0)
            {
                Size = size;
                Red = red;
                Green = green;
                Blue = blue;
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }

        public Ball(int size, int red, int green, int blue, int alpha) : base(red, green, blue, alpha)
        {
            if (red < 256 && red >= 0 && green < 256 & green >= 0 && size > 0
                && blue < 256 && blue >= 0 && alpha < 256 && alpha >= 0)
            {
                Size = size;
                Red = red;
                Green = green;
                Blue = blue;
                Alpha = alpha;
            }
            else
            {
                Console.WriteLine("Wrong Input");
            }
        }

        public static void Pop(Ball ball)
        { 
            ball.Size = 0;
        }

        public void Throw(Ball ball)
        {
            if (ball.Size > 0)
            {
                ThrowTime += 1;
            }
        }

        public int HowManyTimeThrow()
        {
            return ThrowTime;
        }

    }

}