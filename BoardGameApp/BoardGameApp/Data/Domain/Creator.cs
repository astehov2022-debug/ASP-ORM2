namespace BoardGameApp.Data.Domain
{
    public class Creator
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; }

        public virtual IEnumerable<Boardgame> Boardgames { get; set; } = new List<Boardgame>();

    }
}
