using System;

namespace exco_api.Models
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public string img { get; set; }
        public DateTime date { get; set; }
        public BookTypes type { get; set; }
        public Status status { get; set; } = Status.no_overdue;
    }

    public enum BookTypes
    {
        reference,
        lending
    }

    public enum Status
    {
        no_overdue,
        overdue
    }
}