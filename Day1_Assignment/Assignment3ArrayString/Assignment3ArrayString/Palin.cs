//Write a program that extracts from a given text all palindromes, e.g. “ABBA”, “lamal”, “exe”
//and prints them on the console on a single line, separated by comma and space.Print all
//unique palindromes (no duplicates), sorted
//Hi, exe? ABBA! Hog fully a string: ExE.Bob
// a, ABBA, exe, ExE

using System;
namespace Assignment3ArrayString
{
    public class Palin
    {
        public Palin()
        {
            static bool isPalindrome(string str)
            {
                int i = 0, j = str.Length - 1;

                while (i < j)
                {
                    if (str[i++] != str[j--])
                        return true;
                }
                return false;
            }

            static String removePalinWords(string str)
            {
                string final_str = "", word = "";

                str = str + " ";
                int n = str.Length;

                for (int i = 0; i < n; i++)
                {

                    if (str[i] != ' ')
                        word = word + str[i];
                    else
                    {

                        if (!(isPalindrome(word)))
                            final_str += word + " ";

                        word = "";
                    }
                }
                return final_str;
            }
        }
    }
}
