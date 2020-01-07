using System;
using System.Net.Http;
using System.Threading.Tasks;
using DelegatesEventsContainerTest01.Object;
using Newtonsoft.Json;

namespace DelegatesEventsContainerTest01.Service
{
    public class PokemonService : IPokemonService
    {
        private static readonly HttpClient HttpClient = new HttpClient();

        public async Task<Pokemon> GetPokemonAsync(string uri)
        {
            var response = await HttpClient.GetAsync(uri);
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
            HttpClient.Dispose();
        }
    }
}
