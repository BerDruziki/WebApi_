using Microsoft.EntityFrameworkCore;

namespace webapi.data
{
    public class pgsql : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Database=webapi_test;User Id=postgres;Port=5432;Password=Syx@2022;");
        public DbSet<User> users { get; set;}
    }
}