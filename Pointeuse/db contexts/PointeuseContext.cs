using Microsoft.EntityFrameworkCore;
using Pointeuse.Entités;

namespace Pointeuse.db_contexts
{
    public class PointeuseContext : DbContext
    {
        public DbSet<Users> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Pointeuse.db");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
