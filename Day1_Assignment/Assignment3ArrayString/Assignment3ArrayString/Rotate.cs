//Write a program to read an array of n integers (space separated on a single line) and an
//integer k, rotate the array right k times and sum the obtained arrays after each rotation as
//shown below.
//After r rotations the element at position I goes to position (I + r) % n.
//The sum[] array can be calculated by two nested loops: for r = 1... k; for I = 0... n - 1.
//Input Output Comments
//3 2 4 - 1 3 2 5 6 rotated1[] = -1 3 2 4
//2 rotated2[] = 4 - 1 3 2
//sum[] = 3 2 5 6
//1 2 3 4 5 12 10 8 6 9 rotated1[] = 5 1 2 3 4
//3 rotated2[] = 4 5 1 2 3
//rotated3[] = 3 4 5 1 2
//sum[] = 12 10 8 6 9
using System;
namespace Assignment3ArrayString
{
    public class Rotate
    {
        public static int[] RotatedSum(int[] a, int k)
        {
            int r;
            int l;
            List<int> lst = a.ToList();
            List<int> sumlst = lst;
            int n = lst.Count;

            //reminder part
            for (r = 1; r <= k % n; r += 1)
            {
                List<int> nlst = new List<int>();
                nlst.Add(lst[n - 1]);
                for (l = 0; l < n - 1 ; n += 1)
                {
                    nlst.Add(lst[l]);
                    sumlst[l] = sumlst[l]+nlst[l];
                }
                sumlst[n-1] = sumlst[n-1] + nlst[n-1];
                
            }
            //periodic part
            int sum = 0;
            foreach (int i in a)
            {
                sum = sum + i;
            }

            int p = k / n;

            for (int s = 0; s<n; n += 1)
            {
                sumlst[s] = sumlst[s] + p * sum;
            }

            int[] RotatedSum = sumlst.ToArray();
            return RotatedSum;
        }
       
    }
}

