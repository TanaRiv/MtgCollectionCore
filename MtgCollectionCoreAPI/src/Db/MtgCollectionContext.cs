using Microsoft.EntityFrameworkCore;
using MtgCollectionCoreModel.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MtgCollectionCoreAPI.Db
{
    public class MtgCollectionContext : DbContext
    {

        public MtgCollectionContext(DbContextOptions<MtgCollectionContext> options) : base(options)
        {
        }
        public DbSet<Card>? Cards { get; set; }
        
    
    }
}
