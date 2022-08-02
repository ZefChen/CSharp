//Write program to enter an integer number of centuries and convert it to years, days, hours,
//minutes, seconds, milliseconds, microseconds, nanoseconds. Use an appropriate data
//type for every data conversion. Beware of overflows!
//Input: 1
//Output: 1 centuries = 100 years = 36524 days = 876576 hours = 52594560 minutes
//= 3155673600 seconds = 3155673600000 milliseconds = 3155673600000000
//microseconds = 3155673600000000000 nanoseconds
//Input: 5
//Output: 5 centuries = 500 years = 182621 days = 4382904 hours = 262974240
//minutes = 15778454400 seconds = 15778454400000 milliseconds = 15778454400000000
//microseconds = 15778454400000000000 nanoseconds

using System;
using System.Numerics;

namespace Assignment1
{
    public class YearNano
    {
        public static void TimeCalculate()
        {
            Console.WriteLine("Please enter the number.");
            int century = Convert.ToInt32(Console.ReadLine());
            int year = century * 100;
            int day = century * 36524;
            int hour = day * 24;
            int minute = hour * 60;
            long second = Convert.ToInt64(minute) * 60;
            long millisecond = second * 1000;
            BigInteger microsecond = millisecond * 1000;
            BigInteger nanosecond = microsecond * 1000;
            Console.WriteLine($"{century} centuries = {year} years = {day} days = {hour} hours" +
                $" = {minute} minutes = {second} seconds = {millisecond} millisecond " +
                $"= {microsecond} microseconds = {nanosecond} nanoseconds");
        }

    }
}

