using Microsoft.EntityFrameworkCore;


namespace WeightMe.DataModel
{
    public class AppDbContext : DbContext
    {
        public DbSet<WeightEntry> WeightEntries { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=weights.db");
        }
    }
}
