using System;
using System.Threading.Tasks;
using DelegatesEventsContainerTest02.Service;

namespace DelegatesEventsContainerTest02
{
    /*
     * PokemonService will be disposed when container disposes
     */
    public class Worker : IWorker
    {
        private readonly IPokemonService _pokemonService;

        public Worker(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
            Console.WriteLine("PokemonService Hash:" + _pokemonService.GetHashCode());
        }

        public async Task DoWork()
        {
            int pokeCount = 5;
            for (int i = 1; i <= pokeCount; i++)
            {
                var pokemon = await _pokemonService.GetPokemonAsync("https://pokeapi.co/api/v2/pokemon/" + i);
                Console.WriteLine(pokemon.Name);
            }
        }
    }
}
