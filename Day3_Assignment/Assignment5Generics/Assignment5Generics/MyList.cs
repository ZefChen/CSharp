//Create a Generic List data structure MyList<T> that can store any data type.
//Implement the following methods.
//1. void Add (T element)
//2.T Remove(int index)
//3. bool Contains(T element)
//4. void Clear()
//5. void InsertAt(T element, int index)
//6. void DeleteAt(int index)
//7.T Find(int index)
using System;
using System.Collections.Generic;
namespace Assignment5Generics
{
    public class MyList<T>
    {
        public List<T> Lst = new();

      

        public void Add(T element)
        {
            Lst.Add(element);
        }

        public T Remove(int index)
        {
            if (index <= Lst.Count() - 1)
            {
                T beRemove = Lst[index];
                Lst.RemoveAt(index);
                return beRemove;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }

        }

        public bool Contains (T element)
        {
            return Lst.Contains(element);
        }

        public void Clear()
        {
            Lst.Clear();
        }

        public void InsertAt(T element, int index)
        {
            Lst.Insert(index, element);
        }

        public void DeleteAt(int index)
        {
            if (index <= Lst.Count() - 1)
            {
                Lst.RemoveAt(index);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public T Find(int index)
        {
            return Lst[index];
        }

    }
}

