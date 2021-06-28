using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CosmeticsShop.Data.EntityFrameWork
{
    public class CosmeticsDbContextFactory : IDesignTimeDbContextFactory<CosmeticsDbContext>
    {

        public CosmeticsDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CosmeticsDbContext>();
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuration.GetConnectionString("CosmeticsDb");
            optionsBuilder.UseSqlServer(connectionString);
            return new CosmeticsDbContext(optionsBuilder.Options);
        }
    }
}
