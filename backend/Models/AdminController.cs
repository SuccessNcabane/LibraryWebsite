using System;

namespace backend.Models
{
    public class Notice
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public DateTime DatePosted { get; set; } = DateTime.UtcNow;
    }

    public class RoomBooking
    {
        public int Id { get; set; }
        public string? RoomName { get; set; }
        public string? RequestedBy { get; set; }
        public DateTime BookingDate { get; set; }
        public bool IsConfirmed { get; set; } = false;
    }
}

