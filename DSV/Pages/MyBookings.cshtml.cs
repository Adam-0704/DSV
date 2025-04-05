using DSV.classes;
using DSV.Services;
using DSV.classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DSV.Pages
{
    public class MyBookingsModel : PageModel
    {
        private readonly IBookingService _bookingService;

        public List<Booking> MyBookings { get; private set; }

        public MyBookingsModel(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        public void OnGet()
        {
            MyBookings = _bookingService.GetBookings();
        }

        public IActionResult OnPostDelete(int id)
        {
            _bookingService.DeleteBooking(id);
            return RedirectToPage();
        }
    }
}
