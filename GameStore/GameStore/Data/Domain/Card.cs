using System.ComponentModel.DataAnnotations;

namespace GameStore.Data.Domain
{
    public class Card
    {
        public int Id { get; set; }
        [Required]

        public string Number { get; set; } = null!;

        public string Cvc {  get; set; }= null!;

        public string Type { get; set; } = null!;
        [Required]

        public int UserId { get; set; }

        public virtual User User { get; set; } = null!;
        public virtual IEnumerable<Purchase> Purchases { get; set; }= new List<Purchase>();

    }
}
