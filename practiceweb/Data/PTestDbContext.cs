using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using practiceweb.Models;

namespace practiceweb.Data
{
    public class PTestDbContext : DbContext
    {
        public PTestDbContext (DbContextOptions<PTestDbContext> options)
            : base(options)
        {
        }

        public DbSet<practiceweb.Models.Major> Major { get; set; }
    }
}
