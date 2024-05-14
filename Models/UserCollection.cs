using Microsoft.EntityFrameworkCore;

namespace RSOD.Models
{
    public class UserCollection
    {
        public int Id { get; set; }
        public int? CollectionId { get; set; }
        public Collection Collection { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }
    }
}
