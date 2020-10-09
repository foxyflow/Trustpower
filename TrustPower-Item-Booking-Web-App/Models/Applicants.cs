using System;
using System.Collections.Generic;

namespace TrustPower_Item_Booking_Web_App.Models
{
    public partial class Applicants
    {
        public Applicants()
        {
            Bookings = new HashSet<Bookings>();
        }

        public int ApplicantId { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string OrganisationName { get; set; }
        public int AddressId { get; set; }

        public virtual Addresses Address { get; set; }
        public virtual ICollection<Bookings> Bookings { get; set; }
    }
}
