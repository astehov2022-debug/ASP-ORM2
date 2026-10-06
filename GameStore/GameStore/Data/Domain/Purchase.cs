using System.ComponentModel.DataAnnotations;

namespace GameStore.Data.Domain
{
    public class Purchase
    {
        public int Id { get; set; }

        public string Text { get; set; } = null!;

        public string ProductKey { get; set; } = null!;

        public DateTime Date { get; set; }

        [Required]

        public int CardId { get; set; }

        public int GameId { get; set; }





    }
}
