//Write a program that finds the most frequent number in a given sequence of numbers. In
//case of multiple numbers with the same maximal frequency, print the leftmost of them
//Input Output
//4 1 1 4 2 3 4 4 1 2 4 9 3 The number 4 is the most frequent (occurs 5 times)
//7 7 7 0 2 2 2 0 10 10 10 The numbers 2, 7 and 10 have the same maximal
//frequence (each occurs 3 times). The leftmost of them is 7.
using System;
namespace Assignment3ArrayString
{
    public class MostFrequent
    {
        static void print_N_mostFrequentNumber(int[] arr, int n, int k)
        {

            IDictionary<int, int> um = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {

                if (um.ContainsKey(arr[i]))
                    um[arr[i]] += 1;
                else
                    um[arr[i]] = 1;
            }

            // Create a list from elements of HashMap
            List<KeyValuePair<int, int>> list
                = new List<KeyValuePair<int, int>>();
            foreach (KeyValuePair<int, int> entry in um)
            {
                list.Add(entry);
            }

            // Sort the list
            Comparer compare = new Comparer();
            list.Sort(compare);

            for (int i = 0; i < k; i++)
                Console.Write(list[i].Key + " ");
        }

    }
}

