namespace exco_api.Models
{
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public BookTypes type { get; set; }
    }

    public enum BookTypes
    {
        reference,
        lending
    }
}