using System;
namespace Assignment2
{
    public class BirthAnniv
    {
        public static void Birth()
        {
            Console.WriteLine("Please enter your birth date in YYYYMMDD, " +
                "for example if you're born on May 12 1968 then enter 19680512.");
            int Birthdate = Convert.ToInt32(Console.ReadLine());
            int d, m, y;
            d = Birthdate % 100;
            m = ((Birthdate - d) / 100) % 100;
            y = ((Birthdate - d - m * 100) / 10000);

            DateTime Birth = new DateTime(y, m, d);

            DateTime Today = DateTime.Today;

            double DaysOld = (Today - Birth).TotalDays;
            Console.WriteLine($"You are {DaysOld} days old.");
            int daysToNextAnniversary = 10000 - (Convert.ToInt32(DaysOld) % 10000);
            Console.WriteLine($"You are {daysToNextAnniversary} days away from your next anniversary.");
        }
    }
}

