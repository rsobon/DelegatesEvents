using System;
using System.Net.Http;
using System.Threading.Tasks;
using DelegatesEventsContainerTest05.Object;
using Newtonsoft.Json;

namespace DelegatesEventsContainerTest05.Service
{
    public class PokemonService : IPokemonService
    {
        private readonly HttpClient _httpClient;

        public PokemonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Pokemon> GetPokemonAsync(string uri)
        {
            var response = await _httpClient.GetAsync(uri);
            var content = await response.Content.ReadAsStringAsync();

            var pokemon = JsonConvert.DeserializeObject<Pokemon>(content);
            return pokemon;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            _httpClient.Dispose();
        }
    }
}
