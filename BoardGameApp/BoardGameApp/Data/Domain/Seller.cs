using System.ComponentModel.DataAnnotations;

namespace BoardGameApp.Data.Domain
{
    public class Seller
    {
        public int Id { get; set; }

        [Required]
        [Length(5, 20)]
        public string Name { get; set; } = null!;
        [Required]
        public string Address { get; set; } = null!;

        public string Country { get; set; } = null!;
        [Required]
        public string Website { get; set; } = null!;

        public virtual IEnumerable<BoardgameSeller> BoardgameSellers { get; set; } = new List<BoardgameSeller>();

    }
}
