using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Kitty;

namespace Kitty.DB
{
    public class OfficeDbContext : DbContext
    {
        public DbSet<Office> offices { get; set; }

        public OfficeDbContext() : base("DefaultConnection")
        {

        }
    }
}
