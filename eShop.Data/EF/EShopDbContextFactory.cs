using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eShop.Data.EF
{
    public class EShopDbContextFactory : IDesignTimeDbContextFactory<EShopDbContext>
    {
        public EShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var dbHost = "localhost,5000";
            var dbName = "eShop_prod";
            var dbUser = "sa";
            var dbPassword = "Abc@12345";
            var connectionString = $"Data Source={dbHost};Initial Catalog={dbName};User ID={dbUser};Password={dbPassword};Trusted_Connection=false;TrustServerCertificate=true";

            //var connectionString = configuration.GetConnectionString("eShopDb");
            var optionsBuilder = new DbContextOptionsBuilder<EShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new EShopDbContext(optionsBuilder.Options);
        }
    }
}