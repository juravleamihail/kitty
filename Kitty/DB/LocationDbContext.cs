using System;
using System.Collections.Generic;
using System.Data.Entity;
using Kitty.Reader;
using System.Text;
using System.Threading.Tasks;

namespace Kitty.DB
{
 public   class LocationDbContext : DbContext
    {
        public DbSet<Location> locations { get; set; }

        public LocationDbContext():base("DefaultConnection")
        {

        }
    }
}
