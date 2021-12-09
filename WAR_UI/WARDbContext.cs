using Microsoft.EntityFrameworkCore;

namespace WAR_UI
{
    public class WARDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Cards> Cards { get; set; }
        public DbSet<Game> Games { get; set; }
         
        public WARDbContext(DbContextOptions<WARDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Player>(p =>
            {
                p.ToTable("Players");
                p.HasKey(p => p.Id);
                p.Property(p => p.Name);
                p.Property(p => p.Wins);
            });
        }
    }
}
