using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.IO;
using MtgCollectionCore.Db;
using System.Configuration;

namespace MtgCollectionCoreDb.Db
{
   

    public class MtgCollectionContextFactory : IDesignTimeDbContextFactory<MtgCollectionContext>
    {
        public MtgCollectionContext CreateDbContext(string[] args)
        {         

            // Configura las opciones de DbContext
            var optionsBuilder = new DbContextOptionsBuilder<MtgCollectionContext>();
             var connectionString=@"server=DESKTOP-BI1PLJN\SQLEXPRESS ; database=mtgCollection ; User Id=sa; Password=Bluesman.1; TrustServerCertificate=True;";
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("La cadena de conexión 'MtgCollectionConnection' no se encuentra en app.config.");
            }
            optionsBuilder.UseSqlServer(connectionString);

            return new MtgCollectionContext(optionsBuilder.Options);
        }
    }
}
