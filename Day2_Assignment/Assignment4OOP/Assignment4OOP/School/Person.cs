using System;
namespace Assignment4OOP.School
{
    public class Person : IPersonService<T>
    {
        public string personName;
        public DateTime joinDate;
        public DateTime birthDate;
        public decimal hourlyPay; 

        public int Age(object p)
        {
            int Age = DateTime.Today.Year - p.birthDate.Year;
            return Age;
           
        }

        public virtual decimal Salary(object p)
        {
            decimal Salary = p.hourlyPay * 20800;
            return Salary;
        }

    }
}

