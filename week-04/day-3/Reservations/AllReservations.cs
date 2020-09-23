using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reservations
{
    public class AllReservations 
    {
        public List<Reservation> Reservations { get; protected set; }

        public AllReservations()
        {
           Reservations = new List<Reservation>();
        }
        public void AddReservation(Reservation res)
        {
            Reservations.Add(res);
        }
    }
}
