//Print - a - Pyramid.Like the star pattern examples that we saw earlier, create a program that
//will print the following pattern: If you find yourself getting stuck, try recreating the two
//examples that we just talked about in this chapter first. They’re simpler, and you can
//compare your results with the code included above.
//This can actually be a pretty challenging problem, so here is a hint to get you going. I used
//three total loops. One big one contains two smaller loops. The bigger loop goes from line
//to line. The first of the two inner loops prints the correct number of spaces, while the
//second inner loop prints out the correct number of stars.
//    *
//   ***
//  *****
// *******
//*********
using System;
namespace Assignment2
{
    public class PrintPyramid
    {
        public static void pyramid()
        {
            Console.WriteLine("Set how many layers you want your pyramid.");
            int i, c, l; //c stands for check, l stands for level
            l = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= l; i += 1)
            {
                for (c = 1; c <= l - i; c += 1)
                {
                    Console.Write(" ");
                }
                for (c = 1; c <= 2 * i - 1; c += 1)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

        }
    }
}

