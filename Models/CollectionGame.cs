using Microsoft.EntityFrameworkCore;

namespace RSOD.Models
{
    public class CollectionGame
    {
        public int Id { get; set; }
        public ICollection<Game> Games { get; set; }
        public CollectionGame()
        {
            Games = new List<Game>();
        }
        public int CollectionId { get; set; }
        public Collection Collection { get; set; }
    }
}
