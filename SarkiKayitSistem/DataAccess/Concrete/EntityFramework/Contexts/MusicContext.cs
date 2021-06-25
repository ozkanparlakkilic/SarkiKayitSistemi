using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class MusicContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().ToTable("Albums");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-PBVR37A\SQLEXPRESS;Initial Catalog=Music;Integrated Security=True;Connect Timeout=30;
                                                        Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Album> Albums { get; set; }
    }
}
