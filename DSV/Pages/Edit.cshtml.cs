using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DSV.classes;
using DSV.Services; // Import BookingService namespace

namespace DSV.Pages
{
    public class EditModel : PageModel
    {
        private readonly IBookingService _bookingService;

        public EditModel(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        // Property to hold the booking details
        // This property will be bound to the form in the Edit.cshtml page
        [BindProperty]
        public Booking Booking { get; set; } = new Booking();

        public void OnGet(int id)
        {
            // Fetch the booking by ID using BookingService
            Booking = _bookingService.GetBookings().FirstOrDefault(b => b.ID == id);

            if (Booking == null)
            {
                // Hvis der ikke findes en booking med det angivne ID,
                // omdirigeres brugeren til en "NotFound"-side.
                // Dette kan bruges til at vise en fejlmeddelelse eller informere brugeren om,
                // at den ønskede booking ikke eksisterer.
                RedirectToPage("NotFound");
            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Save the updated booking (replace with your data access logic)
            _bookingService.UpdateBooking(Booking);

            return RedirectToPage("Index"); // Redirect to a relevant page
        }
    }
}
