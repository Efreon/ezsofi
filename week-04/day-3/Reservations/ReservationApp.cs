using System;
using System.Collections.Generic;

namespace Reservations
{
    class ReservationApp
    {
        static void Main(string[] args)
        {
            var WeeklyReservations = new List<Reservation>();
            for (int i = 0; i < 10; i++)
            {
                WeeklyReservations.Add(new Reservation());
            }

            for (int i = 0; i < WeeklyReservations.Count; i++)
            {
                Console.WriteLine($"Booking# {WeeklyReservations[i].GetCodeBooking()} for {WeeklyReservations[i].GetDowBooking()}");
            }
            
        }
    }
}
