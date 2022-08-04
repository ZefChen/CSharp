using System;
namespace Assignment4OOP.School
{
    public class Instructor 
    {
        private static decimal yearlyBonus;

        public static decimal BonusSalary(Person p) 
        {
           
            decimal BonusSalary = yearlyBonus *(DateTime.Today.Year - p.joinDate.Year);
            return BonusSalary;
        }

        public override decimal Salary(Person p)
        {
            decimal Salary = p.hourlyPay * 20800 + BonusSalary(p);
            return Salary;
        }

    }
}

