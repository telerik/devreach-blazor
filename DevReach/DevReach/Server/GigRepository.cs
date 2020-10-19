using DevReach.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevReach.Server
{
    public class GigRepository : IGigRepository
    {
        private GigContext context;

        public GigRepository(GigContext context)
        {
            this.context = context;

            // never do this in production

            context.Database.EnsureCreated();
        }

        public async Task<Gig> AddGigAsync(Gig gig)
        {
            context.Add(gig);
            await context.SaveChangesAsync();
            return gig;
        }
    }
}
