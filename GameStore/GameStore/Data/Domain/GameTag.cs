namespace GameStore.Data.Domain
{
    public class GameTag
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        
        public virtual Game Game { get; set; } = null!;

        public int TagId { get; set; }

        public virtual Tag Tag { get; set; } = null!;



    }
}
