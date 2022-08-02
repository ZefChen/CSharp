//Write a program that reverses the words in a given sentence without changing the
//punctuation and spaces
//Use the following separators between the words: . , : ; = ( ) & [ ] " ' \ / ! ? (space).
//All other characters are considered part of words, e.g. C++, a+b, and a77 are
//considered valid words.
//The sentences always start by word and end by separator.
//C# is not C++, and PHP is not Delphi!
//Delphi not is PHP, and C++ not is C#!
//The quick brown fox jumps over the lazy dog /Yes! Really!!!/.
//Really Yes dog lazy the over jumps fox brown /quick! The!!!/
using System;
namespace Assignment3ArrayString
{
    public class ReverseSentence
    {
        public static void reverse(char[] str,int start, int end)
        {
            char temp;

            while (start <= end)
            {
                temp = str[start];
                str[start] = str[end];
                str[end] = temp;
                start++;
                end--;
            }
        }

        
        static char[] reverseWords(char[] s)
        {

            int start = 0;
            for (int end = 0; end < s.Length; end++)
            {

                if (s[end] == ' ')
                {
                    reverse(s, start, end);
                    start = end + 1;
                }
            }
            
            reverse(s, start, s.Length - 1);

            reverse(s, 0, s.Length - 1);
            return s;
        }

    }
}

