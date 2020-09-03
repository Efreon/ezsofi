using System;

namespace CodingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            int dailyCodingHours = 6;

            // The semester is 17 weeks long
            int semesterWeeks = 17;

            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            int workDays = 5;
            int totalCodingHours = semesterWeeks * workDays * dailyCodingHours;
            Console.WriteLine(totalCodingHours);

            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52
            int avgWeeklyCodingHours = 52;
            float totalCodingHoursTwo = avgWeeklyCodingHours * semesterWeeks;
            int dailyHours = 24;
            int weekDays = 7;
            float totalSemesterHours = semesterWeeks * weekDays * dailyHours;
            float codingHoursPercentage = totalCodingHoursTwo / totalSemesterHours*100;
            Console.WriteLine(codingHoursPercentage +"%");
        }
    }
}
