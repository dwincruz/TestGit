using Microsoft.EntityFrameworkCore;

namespace VMNS.ViewModel
{
    public class FilterViewModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public string Transmission { get; set; }
        public string Color { get; set; }
        public string Passenger { get; set; }
        public string Wheels { get; set; }
    }
}
