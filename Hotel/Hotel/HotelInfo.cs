using System.Collections.Generic;

namespace Hotel
{
    class HotelInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageKey { get; set; }
        public Dictionary<string, int> Prices { get; set; }

        public HotelInfo()
        {
            Prices = new Dictionary<string, int>();
        }
    }
}
