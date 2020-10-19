using DevReach.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevReach.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GigsController : ControllerBase
    {
        private IGigRepository _repository;

        public GigsController(IGigRepository repo) => _repository = repo;

        [HttpPost]
        public async Task<Gig> PostGig([FromBody]Gig gig)
        {
            var gigWithId = await _repository.AddGigAsync(gig);
            return gigWithId;
        }
    }
}
