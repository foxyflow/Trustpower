using System;
using System.Collections.Generic;

namespace TrustPower_Item_Booking_Web_App.Models
{
    public partial class Staff
    {
        public Staff()
        {
            Bookings = new HashSet<Bookings>();
        }

        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Bookings> Bookings { get; set; }
    }
}
