using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevReach.Shared
{
    public class GigContext : DbContext 
    {
        public GigContext()
        {
        }

        public GigContext(DbContextOptions<GigContext> options)
            : base(options)
        { }

        public DbSet<Gig> Gigs { get; set; }
    }
}
