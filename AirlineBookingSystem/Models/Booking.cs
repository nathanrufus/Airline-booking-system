// Models/Booking.cs
using System;
using System.Collections.Generic;

namespace AirlineBookingSystem.Models
{
    public class Booking
    {
        public int BookingID { get; set; }
        public DateTime BookingDate { get; set; }
        public int FlightID { get; set; }
        public Flight Flight { get; set; }
        public int SeatID { get; set; }
        public Seat Seat { get; set; }
        public ICollection<Luggage> Luggages { get; set; }
        public ICollection<SpecialNeed> SpecialNeeds { get; set; }
        public ICollection<Transportation> Transportations { get; set; }
    }
}