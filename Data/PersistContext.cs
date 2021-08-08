using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Persist.Models;

namespace Persist.Data
{
    public class PersistContext : DbContext
    {
        public PersistContext (DbContextOptions<PersistContext> options)
            : base(options)
        {
        }

        public DbSet<Persist.Models.Server> Server { get; set; }
    }
}
