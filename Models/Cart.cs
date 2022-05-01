using System.Collections.Generic;

namespace exco_api.Models
{
    public class Cart
    {
        public int id { get; set; }
        public int userid { get; set; }
        public User user { get; set; }
        public ICollection<Item> items { get; set; }
    }
}