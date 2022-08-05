using System;
using Assignment5Generics;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//List<string> test = new (){ "a", "b", "c" };

//MyStack<string> myStack = new MyStack<string>();
//myStack.Push("Go");
//Console.WriteLine(myStack.Pop());

MyList<string> mylist = new MyList<string>();
mylist.Add("Sorry");
Console.Write(mylist.Find(0));