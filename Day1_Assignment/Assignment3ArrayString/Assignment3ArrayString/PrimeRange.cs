//Write a method that calculates all prime numbers in given range and returns them as array
//of integers
using System;
namespace Assignment3ArrayString
{
    public class PrimeRange
    {
        public static int[] FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primelist = new List<int>();
            int i;
            int j;

            for (i = startNum; i <= endNum; i += 1)
            {
                for(j = 2; j * j < i; j += 1)
                {
                    if(i % j == 0)
                    {
                        break;
                    }
                    else
                    {
                        primelist.Add(i);
                    }
                }
            }
            int[] FindPrimesInRange = primelist.ToArray();

            return FindPrimesInRange;
        }
    }
}

