using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zeus.Models;

namespace Zeus.Persistence
{
    public class ZeusDbContext : DbContext
    {
        public ZeusDbContext(DbContextOptions<ZeusDbContext> options)
            : base(options)
        {
        }

        public DbSet<Make> Makes { get; set; }
    }
}
