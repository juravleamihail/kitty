using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Kitty;

namespace Kitty.DB
{
    public class ManagerDbContext : DbContext
    {
        public DbSet<Manager> managers { get; set; }

        public ManagerDbContext() : base("DefaultConnection")
        {

        }
    }
}
