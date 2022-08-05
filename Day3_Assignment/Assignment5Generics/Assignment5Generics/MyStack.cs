//Create a custom Stack class MyStack<T> that can be used with any data type which
//has following methods
//1. int Count()
//2.T Pop()
//3.Void Push()
using System;
using System.Collections.Generic;
namespace Assignment5Generics
{

    public class MyStack<T> 
    {
        private List<T> Lst = new ();

        public int Count()
        {
            return Lst.Count;
        }
       
        //public bool IsEmpty()
        //{
        //    if (Lst.Count == 0)
        //    {
        //        return true;
        //    }
        //    else return false;
        //}

        public T Pop()
        {
            if (Lst.Count == 0)
            {
                throw new NullReferenceException();
            }
            else
            {
                T bePop = Lst[0];
                Lst.Remove(bePop);
                return bePop;
            }
        }

        public void Push(T item)
        {
            Lst.Add(item);
        }
    }
}

