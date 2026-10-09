using System.ComponentModel.DataAnnotations;

namespace BoardGameApp.Data.Domain
{
    public class Boardgame
    {
        public int Id { get; set; }

        [Required]
        [Length(10, 20)]
        public string Name { get; set; } = null!;
        [Required]
        [Range(1, 10.00)]
        public double Rating { get; set; }
        [Required]
        public int YearPublished { get; set; }
        [Required]
        public string CategoryType { get; set; } = null!;

        public string Mechanics { get; set; } = null!;
        [Required]
        public int CreatorId { get; set; }

        public virtual Creator Creator { get; set; } = null!;

        public virtual IEnumerable<BoardgameSeller> BoardgameSellers { get; set; } = new List<BoardgameSeller>();




    }
}
