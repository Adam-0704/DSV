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
            new MeetingRoom { ID = 1, Name = "M�delokale A", Capacity = 10, IsAvailable = true,BookingPage ="/BookingPage" },
            new MeetingRoom { ID = 2, Name = "M�delokale B", Capacity = 20, IsAvailable = true,M�delokaleB = "/M�delokale B" },
            new MeetingRoom { ID = 3, Name = "M�delokale C", Capacity = 15, IsAvailable = true },

        };

        }
       

    }
}
