using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.IO;
using MtgCollectionCoreAPI.Db;
using System.Configuration;

namespace MtgCollectionCoreAPI.Db
{
   

    public class MtgCollectionContextFactory : IDesignTimeDbContextFactory<MtgCollectionContext>
    {
        public MtgCollectionContext CreateDbContext(string[] args)
        {         

         
            IConfigurationRoot configuration = new ConfigurationBuilder()
                      .SetBasePath(Directory.GetCurrentDirectory())
                      .AddJsonFile("appsettings.json")
                      .Build();
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("La cadena de conexión 'MtgCollectionConnection' no se encuentra en app.config.");
            }
            // Configura las opciones de DbContext
            var optionsBuilder = new DbContextOptionsBuilder<MtgCollectionContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new MtgCollectionContext(optionsBuilder.Options);
        }
    }
}
