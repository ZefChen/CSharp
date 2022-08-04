//Create a Color class:
//On a computer, colors are typically represented with a red, green, blue, and alpha
//(transparency) value, usually in the range of 0 to 255. Add these as instance variables.
//A constructor that takes a red, green, blue, and alpha value.
//A constructor that takes just red, green, and blue, while alpha defaults to 255
//(opaque).
//Methods to get and set the red, green, blue, and alpha values from a Colorinstance.
//A method to get the grayscale value for the color, which is the average of the red,
//green and blue values.
using System;
namespace Assignment4OOP.ColorValue
{
    public class Color
    {
        //private int red;
        //private int green;
        //private int blue;
        //private int alpha;

        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int Alpha { get; set; }

        public Color(int red, int green, int blue, int alpha)
        {
            if (red < 256 && red >= 0 && green < 256 & green >= 0
                && blue < 256 && blue >= 0 && alpha < 256 && alpha >= 0)
            {
                Red = red;
                Green = green;
                Blue = blue;
                Alpha = alpha;
            }
            else
            {
                Console.WriteLine("Wrong Input.");
            }
        }

        public Color(int red, int green, int blue)
        {
            if (red < 256 && red >= 0 && green < 256 & green >= 0 && blue < 256 && blue >= 0)
            {
                Alpha = 255;
                Red = red;
                Green = green;
                Blue = blue;
            }
            else
            {
                Console.WriteLine("Wrong Input.");
            }
        }

        public static int grayscale(Color c)
        {
            int grayscale = (c.Red + c.Green + c.Blue) / 3;
            return grayscale;
        }
    }
}

