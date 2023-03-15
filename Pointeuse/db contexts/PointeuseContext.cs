using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Pointeuse.Entités;

namespace Pointeuse.db_contexts
{
    public class PointeuseContext : DbContext
    {
        public DbSet<User> User { get; set; } = null!;

        public DbSet<Pointage> Pointage { get; set; } = null!;

        public DbSet<DetailUser> DetailUser { get; set; } = null!;

        public PointeuseContext()
        {

        }

        public PointeuseContext(DbContextOptions<PointeuseContext> options)
            : base(options)
        {
            //SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Pointeuse.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}