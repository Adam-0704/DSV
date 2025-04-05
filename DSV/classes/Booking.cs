namespace DSV.classes
{
    public class Booking
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public DateOnly DateOnly { get; set; }
        public TimeOnly TimeOnly { get; set; }
        public int RoomID { get; set; } // RoomID property to link to a room
    }

}
