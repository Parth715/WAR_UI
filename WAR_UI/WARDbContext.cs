using Microsoft.EntityFrameworkCore;

namespace WAR_UI
{
    public class WARDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Cards> Cards { get; set; }
         
        public WARDbContext(DbContextOptions<WARDbContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Player>(p =>
            {
                p.ToTable("Players");
                p.HasKey(p => p.Id);
                p.Property(p => p.Name).IsRequired(true);
                p.Property(p => p.Wins);
                p.Property(p => p.Loses);
                p.Property(p => p.Outcome);
            });
            builder.Entity<Cards>(c =>
            {
                c.ToTable("Cards");
                c.HasKey(c => c.Id);
                c.Property(c => c.Cardnumber).IsRequired(true);
                c.Property(c => c.Face).IsRequired(true);

            });
        }
    }
}
