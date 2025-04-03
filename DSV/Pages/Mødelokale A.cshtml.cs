using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DSV.Pages
{
    public class BookingPageModel : PageModel
    {
        public string? ConfirmationMessage { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPostConfirmBooking()
        {
            Console.WriteLine("Booking confirmed!"); // Log til terminalen
            ConfirmationMessage = "Din booking er nu bekræftet!";
            return Page();
        }

    }
}
