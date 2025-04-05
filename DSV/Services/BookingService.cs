using DSV.classes;

namespace DSV.Services
{
    public class BookingService : IBookingService
    {
        private List<Booking> _bookings;

        public BookingService()
        {
            // Initialiser med nogle standarddata
            _bookings = new List<Booking>
            {
                new Booking { ID = 1, Name = "Fællesmøde", DateOnly = new DateOnly(2025, 4, 6), TimeOnly = new TimeOnly(14, 30) },
                new Booking { ID = 2, Name = "Status", DateOnly = new DateOnly(2025, 4, 6), TimeOnly = new TimeOnly(15, 30) },
                new Booking { ID = 3, Name = "Opsamling", DateOnly = new DateOnly(2025, 4, 6), TimeOnly = new TimeOnly(16, 30) }
            };
        }

        // Hent alle bookinger
        public List<Booking> GetBookings()
        {
            return _bookings;
        }

        // Tilføj en ny booking
        public void AddBooking(Booking booking)
        {
            booking.ID = _bookings.Max(b => b.ID) + 1; // Generer nyt ID
            _bookings.Add(booking);
        }

        // Opdater en eksisterende booking
        public void UpdateBooking(Booking updatedBooking)
        {
            var booking = _bookings.FirstOrDefault(b => b.ID == updatedBooking.ID);
            if (booking != null)
            {
                booking.Name = updatedBooking.Name;
                booking.DateOnly = updatedBooking.DateOnly;
                booking.TimeOnly = updatedBooking.TimeOnly;
            }
        }

        // Slet en booking
        public void DeleteBooking(int id)
        {
            var booking = _bookings.FirstOrDefault(b => b.ID == id);
            if (booking != null)
            {
                _bookings.Remove(booking);
            }
        }
    }
}