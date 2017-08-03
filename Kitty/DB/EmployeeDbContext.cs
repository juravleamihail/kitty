using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Kitty;

namespace Kitty.DB
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }

        public EmployeeDbContext():base("DefaultConnection")
        {
           
        }
    }
}
