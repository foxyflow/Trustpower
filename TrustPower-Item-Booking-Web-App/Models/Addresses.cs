using System;
using System.Collections.Generic;

namespace TrustPower_Item_Booking_Web_App.Models
{
    public partial class Addresses
    {
        public Addresses()
        {
            Applicants = new HashSet<Applicants>();
            Bookings = new HashSet<Bookings>();
        }

        public int AddressId { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }

        public virtual ICollection<Applicants> Applicants { get; set; }
        public virtual ICollection<Bookings> Bookings { get; set; }
    }
}
