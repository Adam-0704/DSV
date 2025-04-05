using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DSV.Services;
using DSV.classes;

namespace DSV.Pages
{
    public class BookingPageModel : PageModel
    {
        private readonly IBookingService _bookingService;
        private int _roomid;

        public BookingPageModel(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }


        [BindProperty]
        public string? RoomName { get; set; }

        [BindProperty]
        public string? Name { get; set; }

        [BindProperty]
        public DateOnly Date { get; set; }

        [BindProperty]
        public TimeOnly Time { get; set; }

        public string? ConfirmationMessage { get; set; }

        public void OnGet(int roomId, string roomName)
        {
            _roomid = roomId;
            RoomName = roomName;
        }

        public IActionResult OnPostConfirmBooking()
        {
            Console.WriteLine("Booking confirmed!"); // Log til terminalen

            // Opret en ny booking baseret på POST-data
            var newBooking = new Booking
            {
                Name = Name,
                DateOnly = Date,
                TimeOnly = Time,
                RoomID = _roomid // Fast RoomID til 1
            };

            _bookingService.AddBooking(newBooking); // Tilføj bookingen via BookingService

            ConfirmationMessage = "Din booking er nu bekræftet!";
            return Page();
        }
    }
}