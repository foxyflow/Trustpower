using System;
using System.Collections.Generic;

namespace TrustPower_Item_Booking_Web_App.Models
{
    public partial class Tracking
    {
        public int BookingId { get; set; }
        public int ItemId { get; set; }

        public virtual Bookings Booking { get; set; }
        public virtual Items Item { get; set; }
    }
}
