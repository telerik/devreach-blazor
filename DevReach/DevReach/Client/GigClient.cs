using DevReach.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace DevReach.Client
{
    public class GigClient : IGigRepository
    {
        private HttpClient _client;

        public GigClient(HttpClient client) => _client = client;

        public async Task<Gig> AddGigAsync(Gig gig)
        {
            var result = await _client.PostAsJsonAsync(string.Empty, gig);
            result.EnsureSuccessStatusCode();
            Console.WriteLine(result.Headers.Location);
            return gig;
        }
    }
}
