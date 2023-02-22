using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Pointeuse.Entités;

namespace Pointeuse.db_contexts
{
    public class PointeuseContext : DbContext
    {
        public DbSet<Users> Users { get; set; } = null!;

        public DbSet<Pointage> Pointages { get; set; } = null!;

        public PointeuseContext(DbContextOptions<PointeuseContext> options)
            : base(options)
        {
            //SaveChanges();
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlite("Data Source=Pointeuse.db");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}