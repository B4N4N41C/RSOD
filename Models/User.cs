namespace RSOD.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Photo { get; set; }
        public bool IsAdmin { get; set; }
        public virtual ICollection<Collection> Collections { get; set; }
        public User()
        {
            Collections = new List<Collection>();
        }

        public DateTime CreatedData { get; set; } = DateTime.Now;
    }
}
