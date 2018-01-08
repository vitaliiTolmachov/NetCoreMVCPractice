using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace NetCoreMVCPractice.Models
{
    public class MyAppDbContext : DbContext, IDesignTimeDbContextFactory<MyAppDbContext>
    {
        private readonly IConfiguration Config;
        public MyAppDbContext(DbContextOptions<MyAppDbContext> options)
            : base(options)
        {

        }

        public MyAppDbContext(IConfiguration conf, DbContextOptions<MyAppDbContext> options)
             : base(options)
        {
            this.Config = conf;
        }

        public DbSet<Product> Products { get; set; }
        public MyAppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MyAppDbContext>();
            optionsBuilder.UseSqlServer(Config.GetConnectionString("MVCPractice"));
            return new MyAppDbContext(optionsBuilder.Options);
        }
    }
}