﻿//Copying an Array
//Write code to create a copy of an array. First, start by creating an initial array. (You can use
//whatever type of data you want.) Let’s start with 10 items. Declare an array variable and
//assign it a new array with 10 items in it.Use the things we’ve discussed to put some values
//in the array.
//Now create a second array variable. Give it a new array with the same length as the first.
//Instead of using a number for this length, use the Lengthproperty to get the size of the
//original array.
//Use a loop to read values from the original array and place them in the new array.Also
//print out the contents of both arrays, to be sure everything copied correctly
using System;
namespace Assignment3ArrayString
{
    public class CopyArray
    { 

        public static void copy()
        {
            int[] ten = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] nten = new int[10];

            ten.CopyTo(nten, 0);

            for (int i = 0; i < 10; i++)
            {
                Console.Write(nten[i]);
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(ten[i]);
            }
        }
    }
}

