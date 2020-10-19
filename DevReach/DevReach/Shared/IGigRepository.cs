using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevReach.Shared
{
    public interface IGigRepository
    {
        Task<Gig> AddGigAsync(Gig gig);
    }
}
