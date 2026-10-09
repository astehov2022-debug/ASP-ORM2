using System.ComponentModel.DataAnnotations;

namespace BoardGameApp.Data.Domain
{
    public class BoardgameSeller
    {
        public int Id { get; set; }
        [Required]
        public int BoardgameId { get; set; }

        public virtual Boardgame Boardgame { get; set; } = null!;
        [Required]
        public int SellerId { get; set; }
        public virtual Seller Seller { get; set; } = null!;

     
    }
}
