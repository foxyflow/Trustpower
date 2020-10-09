using System;
using System.Collections.Generic;

namespace TrustPower_Item_Booking_Web_App.Models
{
    public partial class Items
    {
        public Items()
        {
            Tracking = new HashSet<Tracking>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDescription { get; set; }
        public int DepotId { get; set; }

        public virtual Depots Depot { get; set; }
        public virtual ICollection<Tracking> Tracking { get; set; }
    }
}
