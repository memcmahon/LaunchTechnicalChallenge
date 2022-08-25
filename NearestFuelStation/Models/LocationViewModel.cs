using Microsoft.AspNetCore.Mvc.Rendering;

namespace NearestFuelStation.Models
{
    public class LocationViewModel
    {
        public string Location { get; set; } = "Turing";

        public List<SelectListItem> Locations { get; } = new List<SelectListItem>
        {
            new SelectListItem { Text = "Turing", Value = "1331 17th St LL100, Denver, CO 80202" }
        };
    }
}
