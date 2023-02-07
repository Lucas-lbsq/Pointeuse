using Microsoft.EntityFrameworkCore;
using Pointeuse.Entités;

namespace Pointeuse.db_contexts
{
    public class VilleInfoContext : DbContext
    {
        public DbSet<Ville> Villes { get; set; } = null!;

        public DbSet<PointOfInterest> PointsOfInsterest { get; set; } = null!;

        public VilleInfoContext(DbContextOptions<VilleInfoContext> options)
            :base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=VilleInfo.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
