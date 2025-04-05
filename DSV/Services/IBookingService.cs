using System.Collections.Generic;
using DSV.classes;

namespace DSV.Services
{
    public interface IBookingService
    {
        void AddBooking(Booking newBooking);
        void DeleteBooking(int id);
        List<Booking> GetBookings();
        void UpdateBooking(Booking booking);
    }
}