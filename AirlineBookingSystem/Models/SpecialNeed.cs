// Models/SpecialNeed.cs
namespace AirlineBookingSystem.Models
{
    public class SpecialNeed
    {
        public int SpecialNeedID { get; set; }
        public string NeedDescription { get; set; }
        public int BookingID { get; set; }
        public Booking Booking { get; set; }
    }
}