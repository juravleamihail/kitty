using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Kitty;

namespace Kitty.DB
{
    public class BussinesTripDbContext : DbContext
    {
        public DbSet<BusinessTrip> trips { get; set; }

        public BussinesTripDbContext():base("DefaultConnection")
        {

        }
    }
}
