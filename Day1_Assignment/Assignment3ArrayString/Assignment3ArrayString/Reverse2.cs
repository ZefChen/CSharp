//Write a program that reads a string from the console, reverses its letters and prints the
//result back at the console.
//Write in two ways
//Convert the string to char array, reverse it, then convert it to string again
//Print the letters of the string in back direction (from the last to the first) in a for-loop
//Input Output
//sample elpmas
//24tvcoi92 29iocvt42
using System;
namespace Assignment3ArrayString
{
    public class Reverse2
    {
        public static void CharRev(string a)
        {
            int l = a.Length;
            for(int i = l - 1; i >= 0; i -= 1)
            {
                Console.Write(a[i]);
            }
        }
        
    }
}

