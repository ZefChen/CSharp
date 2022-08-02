//Write a program that finds the longest sequence of equal elements in an array of integers.
//If several longest sequences exist, print the leftmost one.
//Input Output
//2 1 1 2 3 3 2 2 2 1 2 2 2
//1 1 1 2 3 1 3 3 1 1 1
//4 4 4 4 4 4 4 4
//0 1 1 5 2 2 6 3 3 1 1
using System;
namespace Assignment3ArrayString
{
    public class Sequence
    {
        static int findLongestConseqSubseq(int[] arr, int n)
        {

            Array.Sort(arr);

            int ans = 0, count = 0;

            List<int> v = new List<int>();
            v.Add(10);

           
            for (int i = 1; i < n; i++)
            {
                if (arr[i] != arr[i - 1])
                    v.Add(arr[i]);
            }

            
            for (int i = 0; i < v.Count; i++)
            {

                
                if (i > 0 && v[i] == v[i - 1] + 1)
                    count++;
                else
                    count = 1;

                ans = Math.Max(ans, count);
            }
            return ans;
        }

    }
}

