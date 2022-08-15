﻿using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AP.User.EntityFrameworkCore
{
    public class UserHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<UserHttpApiHostMigrationsDbContext>
    {
        public UserHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<UserHttpApiHostMigrationsDbContext>()
                //.UseSqlServer(configuration.GetConnectionString("User"));
                .UseMySql(configuration.GetConnectionString("User"), MySqlServerVersion.LatestSupportedServerVersion);
            return new UserHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
