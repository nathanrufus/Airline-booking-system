// Models/Luggage.cs
namespace AirlineBookingSystem.Models
{
    public class Luggage
    {
        public int LuggageID { get; set; }
        public string LuggageType { get; set; }
        public double Weight { get; set; }
        public int BookingID { get; set; }
        public Booking Booking { get; set; }
    }
}
