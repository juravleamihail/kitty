using System;
using System.Collections.Generic;
using System.Data.Entity;
using Kitty.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitty.DB
{
    class LocationDbContext : DbContext
    {
        public DbSet<Location> locations { get; set; }

        public LocationDbContext():base("DefaultConnection")
        {
            JsonLocationReader.Cities();
        }
    }
}
