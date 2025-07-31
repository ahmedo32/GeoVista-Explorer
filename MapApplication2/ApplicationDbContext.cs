using Microsoft.EntityFrameworkCore;

namespace MapApplication2.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<GeoEntity> GeoEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<GeoEntity>(entity =>
            {
                entity.ToTable("GeoEntities");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Type).IsRequired().HasConversion<int>();
                entity.Property(e => e.Wkt).IsRequired();
            });
        }
    }
}
