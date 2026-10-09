using BoardGameApp.Data.Domain;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BoardGameApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Boardgame> Boardgames { get; set; } = null!;

        public DbSet<Seller> Sellers { get; set; } = null!;


        public DbSet<Creator> Creators { get; set; } = null!;

        public DbSet<BoardgameSeller> BoardgameSellers { get; set; } = null!;







    }
}
