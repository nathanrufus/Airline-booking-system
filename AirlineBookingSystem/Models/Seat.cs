// Models/Seat.cs
using System.ComponentModel.DataAnnotations;

namespace AirlineBookingSystem.Models
{
    public class Seat
    {
        public int SeatID { get; set; }
        public string SeatNumber { get; set; }
        public bool IsAvailable { get; set; }
        public int FlightID { get; set; }
        public Flight Flight { get; set; }
    }
}