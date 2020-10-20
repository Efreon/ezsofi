using System;

namespace SecondsInADay
{
    class Program
    {
        static void Main(string[] args)
        {
            int currentHours = 14;
            int currentMinutes = 34;
            int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented by the variables
            DateTime now = DateTime.Now;
            int currentYear = now.Year;
            int currentMonth = now.Month;
            int currentDay = now.Day;

            int lastHours = 23;
            int lastMinutes = 59;
            int lastSeconds = 59;

            DateTime dayEnd = new DateTime(currentYear, currentMonth, currentDay, lastHours, lastMinutes, lastSeconds);
            DateTime currentTime = new DateTime(currentYear, currentMonth, currentDay, currentHours, currentMinutes, currentSeconds);
            // Console.WriteLine(currentTime.ToString());

            int diffInSeconds = (int)(dayEnd - currentTime).TotalSeconds;
            Console.WriteLine(diffInSeconds+1);

            int secondsInDay = 24 * 60 * 60;
            int secondsNow = (14 * 60 * 60) + (34 * 60) + 42;
            int secondsLeft = secondsInDay - secondsNow;
            Console.WriteLine(secondsLeft);


        }
    }
}
