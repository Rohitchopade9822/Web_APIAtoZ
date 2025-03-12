using Microsoft.EntityFrameworkCore;
using Webtraning.Models.Domain;

namespace Webtraning.Data
{
    public class DbConnection: DbContext
    {
        public DbConnection(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regiones { get; set; }
        public DbSet<walk> walks { get; set; }
    }
}
