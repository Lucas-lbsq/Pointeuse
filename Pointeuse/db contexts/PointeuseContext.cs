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

        public bool dansAppli;

        public PointeuseContext()
        {

        }

        public PointeuseContext(DbContextOptions<PointeuseContext> options, bool dansAppli)
            : base(options)
        {
            this.dansAppli = dansAppli;
            //SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!dansAppli)
            {
                optionsBuilder.UseSqlite("Data Source=Pointeuse.db");
                base.OnConfiguring(optionsBuilder);
            }
        }
    }
}