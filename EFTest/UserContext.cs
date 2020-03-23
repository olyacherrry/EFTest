using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest
{
    class UserContext : DbContext
    {
        public UserContext()
            : base("DbConnection")
        {Database.EnsureCreated();}

        public DbSet<User> Users { get; set; }
    }
}
