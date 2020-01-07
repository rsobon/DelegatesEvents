using System;
using System.Threading.Tasks;
using DelegatesEventsContainerTest03.Service;

namespace DelegatesEventsContainerTest03
{
    /*
     * PokemonServiceFactory is injected which uses service locator to resolve PokemonService in runtime.
     * Every time PokemonService is created it creates new HttpClient instance.
     */
    public class Worker : IWorker
    {
        private readonly IPokemonServiceFactory _pokemonServiceFactory;

        public Worker(IPokemonServiceFactory pokemonServiceFactory)
        {
            _pokemonServiceFactory = pokemonServiceFactory;
            Console.WriteLine("PokemonServiceFactory Hash:" + _pokemonServiceFactory.GetHashCode());
        }

        public async Task DoWork()
        {
            int pokeCount = 5;

            using (var pokemonService = _pokemonServiceFactory.GetPokemonService())
            {
                Console.WriteLine("PokemonService Hash:" + pokemonService.GetHashCode());

                for (int i = 1; i <= pokeCount; i++)
                {
                    var pokemon = await pokemonService.GetPokemonAsync("https://pokeapi.co/api/v2/pokemon/" + i);
                    Console.WriteLine(pokemon.Name);
                }
            }
        }
    }
}
