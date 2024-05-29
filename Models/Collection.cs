namespace RSOD.Models
{
    public class Collection
    {
        public int Id { get; set; }
        public string? PhotoCollection { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public int? UserId {  get; set; }
        public User? User { get; set; }
        public virtual ICollection<Game> Games { get; set; }
     
        public Collection()
        {
            Games = new List<Game>();
        }
        public DateTime CreatedData { get; set; } = DateTime.Now;
    }
}