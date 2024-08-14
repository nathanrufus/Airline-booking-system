
// Models/Transportation.cs
namespace AirlineBookingSystem.Models
{
    public class Transportation
    {
        public int TransportationID { get; set; }
        public string TransportationType { get; set; }
        public int BookingID { get; set; }
        public Booking Booking { get; set; }
    }
}
