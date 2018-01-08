using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace NetCoreMVCPractice.Models
{
    public class MyAppDbContext : DbContext, IDesignTimeDbContextFactory<MyAppDbContext>
    {
        private IConfigurationRoot Configuration;
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options)
            : base(options)
        {

        }

        public MyAppDbContext()
        {
            
        }

        public DbSet<Product> Products { get; set; }
        public MyAppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyAppDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=MVCPractice;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new MyAppDbContext(optionsBuilder.Options);
        }
    }
}