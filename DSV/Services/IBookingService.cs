using System.Collections.Generic;
using DSV.classes;

namespace DSV.Services
{
    public interface IBookingService
    {
        void AddBooking(Booking newBooking);
        List<Booking> GetBookings();
        void UpdateBooking(Booking booking);
    }
}