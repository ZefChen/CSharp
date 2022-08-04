using System;
namespace Assignment4OOP.School
{
    public interface IPersonService<T> where T : class
    {
        int Age(object p);
        decimal Salary(object p);
        string[] GetAddress(object p);
    }
}

