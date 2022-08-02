using System;
namespace Assignment3ArrayString
{
    public class Comparer : IComparer<KeyValuePair<int, int>>
    {
        public int Compare(KeyValuePair<int, int> p2,
                       KeyValuePair<int, int> p1)
        {
            if (p1.Value == p2.Value)
                return p1.Key.CompareTo(p2.Key);

            return p1.Value.CompareTo(p2.Value);
        }
    }

}

