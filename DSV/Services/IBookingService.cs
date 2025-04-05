using System.Collections.Generic;
using DSV.classes;

namespace DSV.Services
{
    public interface IBookingService
    {
        List<Booking> GetBookings();
        void UpdateBooking(Booking booking);
    }
}