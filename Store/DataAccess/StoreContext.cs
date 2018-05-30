using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Store.Data;
using System.Threading.Tasks;

namespace Store.DataAccess
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("StoreDbContext")
        {

        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }
    }
}
