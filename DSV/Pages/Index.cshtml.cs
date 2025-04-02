using DSV.classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DSV.Pages
{
    public class IndexModel : PageModel
    {
        public List<MeetingRoom> MeetingRooms;

        public void OnGet()
        {
            MeetingRooms = new List<MeetingRoom>
        {
            new MeetingRoom { ID = 1, Name = "Mødelokale A", Capacity = 10, IsAvailable = true,BookingPage ="/BookingPage" },
            new MeetingRoom { ID = 2, Name = "Mødelokale B", Capacity = 20, IsAvailable = true,MødelokaleB = "/Mødelokale B" },
            new MeetingRoom { ID = 3, Name = "Mødelokale C", Capacity = 15, IsAvailable = true },

        };

        }
       

    }
}
