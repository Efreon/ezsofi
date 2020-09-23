using System;
using System.Collections.Generic;
using System.Text;

namespace Reservations
{
    public class Reservation : IReservationy
    {
        public string BookingNum { get; protected set; }
        public string DOW { get; protected set; }

        public Reservation() 
        {
            // RANDOMLY GENERATED BOOKING NUMBER
            const string characters = "ABCDEFGHIJKLMNOPQRSTVWXYZ0123456789";
            int length = 8;
            var RandBookingNum = new StringBuilder();
            Random rnd = new Random();
            for (var i = 0; i < length; i++)
            {
                var c = characters[rnd.Next(0, characters.Length)];
                RandBookingNum.Append(c);
            }
            BookingNum = RandBookingNum.ToString();

            // RANDOMLY GENERATED WEEKDAYS
            {
                string[] weekdays = new string[] { "MON", "TUE", "WED", "THU", "FRI", "SAT", "SUN" };
                int rndDOW = new Random().Next(0, 7);
                DOW = weekdays[rndDOW];
            }
        }

        public string GetDowBooking()
        {
            return DOW;
        }

        public string GetCodeBooking()
        {
            return BookingNum;
        }
    }
}
