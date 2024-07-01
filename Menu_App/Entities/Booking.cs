using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Menu_App.Entities
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BookingDate { get; set; }
        public string BookingTime { get; set; }
        public int GuestCount { get; set; }
        public string Description { get; set; }
    }
}
